/// <reference path="jquery-1.4.1.min-vsdoc.js" />
/// <reference path="jquery.validate-vsdoc.js" />
/// <reference path="MicrosoftMvcJQueryValidation.js" />

/*
Note: This script *MUST* run before $(document).ready but after the form validation json object has been output by MVC. This is
because the MicrosoftMvcJQueryValidation file "pops" the configuration we want off an array so it becomes inaccessible - so we
must grab what we need before that happens in document ready. We also must setup the defaults for the jQuery validator before
it is created by the MVC jQuery adapter script. The best way to handle this is to put a reference to this script at the bottom 
of the HTML page (or at least after the closing form tag).
    
Fundamentally this script is a hack - I hope the MicrosoftMvcJQueryValidation file will just do all this for us in the future.
*/

(function () {
    // extract and preserve the ID before it is cleared down
    var validationSummaryId = '#' + window.mvcClientValidationMetadata[0].ValidationSummaryId;

    // remove all errors in the list
    function clearErrors() {
        $(validationSummaryId + ' ul').remove();
        $('<ul />').appendTo($(validationSummaryId));
    }

    // display a list of errors
    function displayErrors(errors) {
        if (!errors)
            return;
        errors.sort();
        $.each(errors, function () {
            $('<li>' + this + '</li>').appendTo($(validationSummaryId + ' ul'));
        });
        $(validationSummaryId).removeClass('validation-summary-valid');
        $(validationSummaryId).addClass('validation-summary-errors');
    }

    // hide errors
    function displaySuccess() {
        $(validationSummaryId).removeClass('validation-summary-errors');
        $(validationSummaryId).addClass('validation-summary-valid');
    }

    // change the default showErrors behaviour
    $.validator.setDefaults({
        showErrors: function (errorMap, errorList) {
            // Extracts existing field validation errors that
            // are not necessarily part of the current validation phase.
            // It's important to note that errorMap and errorList
            // only contain failures from the current validation phase,
            // so for example when you tab out of a field only that
            // field is validated, and hence errorList will only
            // ever contain a single error.
            // Therefore this script combines this result with any
            // previous failures already being displayed.            
            var map = {};
            $('.input-validation-error').each(function () {
                var element = this;
                var txt = $('#' + element.id + '_validationMessage').text();
                map[element.name] = txt;
            });

            // add the errors from this validation phase
            // map will ensure they're unique as it's keyed on control name
            $.extend(map, errorMap);

            // convert all these unique errors into a nice simple array
            var messages = [];
            for (var item in map) {
                messages[messages.length] = map[item];
            }

            // remove existing errors
            clearErrors();
            // display error list or hide validation summary
            messages.length ? displayErrors(messages) : displaySuccess();
            // let jQuery highlight the fields
            this.defaultShowErrors();
        }
    });
})();
