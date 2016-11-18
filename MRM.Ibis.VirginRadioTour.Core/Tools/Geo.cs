using System.Collections.Generic;

namespace MRM.Ibis.VirginRadioTour.Core.Tools
{
    /// <summary>
    /// Fournit des propriétés et des méthodes pour manipuler la dimension géographique
    /// </summary>
    public static class Geo
    {
        /// <summary>
        /// Obtient la liste des départements français
        /// </summary>
        /// <returns>Objet Collection contenant la liste des départements français</returns>
        public static ICollection<Department> Departments()
        {
            ICollection<Department> departments = new List<Department>(){
                new Department(){ Region = 01, Dep = "971", ChefLieu = "97105", TNCC = 3, NCC = "GUADELOUPE", NCCENR = "Guadeloupe" },
                new Department(){ Region = 02, Dep = "972", ChefLieu = "97209", TNCC = 3, NCC = "MARTINIQUE", NCCENR = "Martinique" },
                new Department(){ Region = 03, Dep = "973", ChefLieu = "97302", TNCC = 3, NCC = "GUYANE", NCCENR = "Guyane" },
                new Department(){ Region = 04, Dep = "974", ChefLieu = "97411", TNCC = 0, NCC = "LA REUNION", NCCENR = "La Réunion" },
                new Department(){ Region = 06, Dep = "976", ChefLieu = "97608", TNCC = 0, NCC = "MAYOTTE", NCCENR = "Mayotte" },
                new Department(){ Region = 11, Dep = "75", ChefLieu = "75056", TNCC = 0, NCC = "PARIS", NCCENR = "Paris" },
                new Department(){ Region = 11, Dep = "95", ChefLieu = "95500", TNCC = 2, NCC = "VAL-D'OISE", NCCENR = "Val-d'Oise" },
                new Department(){ Region = 11, Dep = "94", ChefLieu = "94028", TNCC = 2, NCC = "VAL-DE-MARNE", NCCENR = "Val-de-Marne" },
                new Department(){ Region = 11, Dep = "93", ChefLieu = "93008", TNCC = 3, NCC = "SEINE-SAINT-DENIS", NCCENR = "Seine-Saint-Denis" },
                new Department(){ Region = 11, Dep = "92", ChefLieu = "92050", TNCC = 4, NCC = "HAUTS-DE-SEINE", NCCENR = "Hauts-de-Seine" },
                new Department(){ Region = 11, Dep = "91", ChefLieu = "91228", TNCC = 5, NCC = "ESSONNE", NCCENR = "Essonne" },
                new Department(){ Region = 11, Dep = "78", ChefLieu = "78646", TNCC = 4, NCC = "YVELINES", NCCENR = "Yvelines" },
                new Department(){ Region = 11, Dep = "77", ChefLieu = "77288", TNCC = 0, NCC = "SEINE-ET-MARNE", NCCENR = "Seine-et-Marne" },
                new Department(){ Region = 21, Dep = "51", ChefLieu = "51108", TNCC = 3, NCC = "MARNE", NCCENR = "Marne" },
                new Department(){ Region = 21, Dep = "10", ChefLieu = "10387", TNCC = 5, NCC = "AUBE", NCCENR = "Aube" },
                new Department(){ Region = 21, Dep = "08", ChefLieu = "08105", TNCC = 4, NCC = "ARDENNES", NCCENR = "Ardennes" },
                new Department(){ Region = 21, Dep = "52", ChefLieu = "52121", TNCC = 3, NCC = "HAUTE-MARNE", NCCENR = "Haute-Marne" },
                new Department(){ Region = 22, Dep = "60", ChefLieu = "60057", TNCC = 5, NCC = "OISE", NCCENR = "Oise" },
                new Department(){ Region = 22, Dep = "80", ChefLieu = "80021", TNCC = 3, NCC = "SOMME", NCCENR = "Somme" },
                new Department(){ Region = 22, Dep = "02", ChefLieu = "02408", TNCC = 5, NCC = "AISNE", NCCENR = "Aisne" },
                new Department(){ Region = 23, Dep = "27", ChefLieu = "27229", TNCC = 5, NCC = "EURE", NCCENR = "Eure" },
                new Department(){ Region = 23, Dep = "76", ChefLieu = "76540", TNCC = 3, NCC = "SEINE-MARITIME", NCCENR = "Seine-Maritime" },
                new Department(){ Region = 24, Dep = "28", ChefLieu = "28085", TNCC = 1, NCC = "EURE-ET-LOIR", NCCENR = "Eure-et-Loir" },
                new Department(){ Region = 24, Dep = "45", ChefLieu = "45234", TNCC = 2, NCC = "LOIRET", NCCENR = "Loiret" },
                new Department(){ Region = 24, Dep = "41", ChefLieu = "41018", TNCC = 0, NCC = "LOIR-ET-CHER", NCCENR = "Loir-et-Cher" },
                new Department(){ Region = 24, Dep = "37", ChefLieu = "37261", TNCC = 1, NCC = "INDRE-ET-LOIRE", NCCENR = "Indre-et-Loire" },
                new Department(){ Region = 24, Dep = "36", ChefLieu = "36044", TNCC = 5, NCC = "INDRE", NCCENR = "Indre" },
                new Department(){ Region = 24, Dep = "18", ChefLieu = "18033", TNCC = 2, NCC = "CHER", NCCENR = "Cher" },
                new Department(){ Region = 25, Dep = "14", ChefLieu = "14118", TNCC = 2, NCC = "CALVADOS", NCCENR = "Calvados" },
                new Department(){ Region = 25, Dep = "50", ChefLieu = "50502", TNCC = 3, NCC = "MANCHE", NCCENR = "Manche" },
                new Department(){ Region = 25, Dep = "61", ChefLieu = "61001", TNCC = 5, NCC = "ORNE", NCCENR = "Orne" },
                new Department(){ Region = 26, Dep = "21", ChefLieu = "21231", TNCC = 3, NCC = "COTE-D'OR", NCCENR = "Côte-d'Or" },
                new Department(){ Region = 26, Dep = "89", ChefLieu = "89024", TNCC = 5, NCC = "YONNE", NCCENR = "Yonne" },
                new Department(){ Region = 26, Dep = "71", ChefLieu = "71270", TNCC = 0, NCC = "SAONE-ET-LOIRE", NCCENR = "Saône-et-Loire" },
                new Department(){ Region = 26, Dep = "58", ChefLieu = "58194", TNCC = 3, NCC = "NIEVRE", NCCENR = "Nièvre" },
                new Department(){ Region = 31, Dep = "62", ChefLieu = "62041", TNCC = 2, NCC = "PAS-DE-CALAIS", NCCENR = "Pas-de-Calais" },
                new Department(){ Region = 31, Dep = "59", ChefLieu = "59350", TNCC = 2, NCC = "NORD", NCCENR = "Nord" },
                new Department(){ Region = 41, Dep = "57", ChefLieu = "57463", TNCC = 3, NCC = "MOSELLE", NCCENR = "Moselle" },
                new Department(){ Region = 41, Dep = "88", ChefLieu = "88160", TNCC = 4, NCC = "VOSGES", NCCENR = "Vosges" },
                new Department(){ Region = 41, Dep = "55", ChefLieu = "55029", TNCC = 3, NCC = "MEUSE", NCCENR = "Meuse" },
                new Department(){ Region = 41, Dep = "54", ChefLieu = "54395", TNCC = 0, NCC = "MEURTHE-ET-MOSELLE", NCCENR = "Meurthe-et-Moselle" },
                new Department(){ Region = 42, Dep = "67", ChefLieu = "67482", TNCC = 2, NCC = "BAS-RHIN", NCCENR = "Bas-Rhin" },
                new Department(){ Region = 42, Dep = "68", ChefLieu = "68066", TNCC = 2, NCC = "HAUT-RHIN", NCCENR = "Haut-Rhin" },
                new Department(){ Region = 43, Dep = "90", ChefLieu = "90010", TNCC = 0, NCC = "TERRITOIRE DE BELFORT", NCCENR = "Territoire de Belfort" },
                new Department(){ Region = 43, Dep = "70", ChefLieu = "70550", TNCC = 3, NCC = "HAUTE-SAONE", NCCENR = "Haute-Saône" },
                new Department(){ Region = 43, Dep = "39", ChefLieu = "39300", TNCC = 2, NCC = "JURA", NCCENR = "Jura" },
                new Department(){ Region = 43, Dep = "25", ChefLieu = "25056", TNCC = 2, NCC = "DOUBS", NCCENR = "Doubs" },
                new Department(){ Region = 52, Dep = "49", ChefLieu = "49007", TNCC = 0, NCC = "MAINE-ET-LOIRE", NCCENR = "Maine-et-Loire" },
                new Department(){ Region = 52, Dep = "85", ChefLieu = "85191", TNCC = 3, NCC = "VENDEE", NCCENR = "Vendée" },
                new Department(){ Region = 52, Dep = "72", ChefLieu = "72181", TNCC = 3, NCC = "SARTHE", NCCENR = "Sarthe" },
                new Department(){ Region = 52, Dep = "53", ChefLieu = "53130", TNCC = 3, NCC = "MAYENNE", NCCENR = "Mayenne" },
                new Department(){ Region = 52, Dep = "44", ChefLieu = "44109", TNCC = 3, NCC = "LOIRE-ATLANTIQUE", NCCENR = "Loire-Atlantique" },
                new Department(){ Region = 53, Dep = "56", ChefLieu = "56260", TNCC = 2, NCC = "MORBIHAN", NCCENR = "Morbihan" },
                new Department(){ Region = 53, Dep = "35", ChefLieu = "35238", TNCC = 1, NCC = "ILLE-ET-VILAINE", NCCENR = "Ille-et-Vilaine" },
                new Department(){ Region = 53, Dep = "29", ChefLieu = "29232", TNCC = 2, NCC = "FINISTERE", NCCENR = "Finistère" },
                new Department(){ Region = 53, Dep = "22", ChefLieu = "22278", TNCC = 4, NCC = "COTES-D'ARMOR", NCCENR = "Côtes-d'Armor" },
                new Department(){ Region = 54, Dep = "86", ChefLieu = "86194", TNCC = 3, NCC = "VIENNE", NCCENR = "Vienne" },
                new Department(){ Region = 54, Dep = "79", ChefLieu = "79191", TNCC = 4, NCC = "DEUX-SEVRES", NCCENR = "Deux-Sèvres" },
                new Department(){ Region = 54, Dep = "17", ChefLieu = "17300", TNCC = 3, NCC = "CHARENTE-MARITIME", NCCENR = "Charente-Maritime" },
                new Department(){ Region = 54, Dep = "16", ChefLieu = "16015", TNCC = 3, NCC = "CHARENTE", NCCENR = "Charente" },
                new Department(){ Region = 72, Dep = "33", ChefLieu = "33063", TNCC = 3, NCC = "GIRONDE", NCCENR = "Gironde" },
                new Department(){ Region = 72, Dep = "47", ChefLieu = "47001", TNCC = 0, NCC = "LOT-ET-GARONNE", NCCENR = "Lot-et-Garonne" },
                new Department(){ Region = 72, Dep = "64", ChefLieu = "64445", TNCC = 4, NCC = "PYRENEES-ATLANTIQUES", NCCENR = "Pyrénées-Atlantiques" },
                new Department(){ Region = 72, Dep = "40", ChefLieu = "40192", TNCC = 4, NCC = "LANDES", NCCENR = "Landes" },
                new Department(){ Region = 72, Dep = "24", ChefLieu = "24322", TNCC = 3, NCC = "DORDOGNE", NCCENR = "Dordogne" },
                new Department(){ Region = 73, Dep = "32", ChefLieu = "32013", TNCC = 2, NCC = "GERS", NCCENR = "Gers" },
                new Department(){ Region = 73, Dep = "31", ChefLieu = "31555", TNCC = 3, NCC = "HAUTE-GARONNE", NCCENR = "Haute-Garonne" },
                new Department(){ Region = 73, Dep = "09", ChefLieu = "09122", TNCC = 5, NCC = "ARIEGE", NCCENR = "Ariège" },
                new Department(){ Region = 73, Dep = "12", ChefLieu = "12202", TNCC = 5, NCC = "AVEYRON", NCCENR = "Aveyron" },
                new Department(){ Region = 73, Dep = "82", ChefLieu = "82121", TNCC = 0, NCC = "TARN-ET-GARONNE", NCCENR = "Tarn-et-Garonne" },
                new Department(){ Region = 73, Dep = "81", ChefLieu = "81004", TNCC = 2, NCC = "TARN", NCCENR = "Tarn" },
                new Department(){ Region = 73, Dep = "46", ChefLieu = "46042", TNCC = 2, NCC = "LOT", NCCENR = "Lot" },
                new Department(){ Region = 73, Dep = "65", ChefLieu = "65440", TNCC = 4, NCC = "HAUTES-PYRENEES", NCCENR = "Hautes-Pyrénées" },
                new Department(){ Region = 74, Dep = "19", ChefLieu = "19272", TNCC = 3, NCC = "CORREZE", NCCENR = "Corrèze" },
                new Department(){ Region = 74, Dep = "87", ChefLieu = "87085", TNCC = 3, NCC = "HAUTE-VIENNE", NCCENR = "Haute-Vienne" },
                new Department(){ Region = 74, Dep = "23", ChefLieu = "23096", TNCC = 3, NCC = "CREUSE", NCCENR = "Creuse" },
                new Department(){ Region = 82, Dep = "01", ChefLieu = "01053", TNCC = 5, NCC = "AIN", NCCENR = "Ain" },
                new Department(){ Region = 82, Dep = "38", ChefLieu = "38185", TNCC = 5, NCC = "ISERE", NCCENR = "Isère" },
                new Department(){ Region = 82, Dep = "73", ChefLieu = "73065", TNCC = 3, NCC = "SAVOIE", NCCENR = "Savoie" },
                new Department(){ Region = 82, Dep = "69", ChefLieu = "69123", TNCC = 2, NCC = "RHONE", NCCENR = "Rhône" },
                new Department(){ Region = 82, Dep = "42", ChefLieu = "42218", TNCC = 3, NCC = "LOIRE", NCCENR = "Loire" },
                new Department(){ Region = 82, Dep = "07", ChefLieu = "07186", TNCC = 5, NCC = "ARDECHE", NCCENR = "Ardèche" },
                new Department(){ Region = 82, Dep = "26", ChefLieu = "26362", TNCC = 3, NCC = "DROME", NCCENR = "Drôme" },
                new Department(){ Region = 82, Dep = "74", ChefLieu = "74010", TNCC = 3, NCC = "HAUTE-SAVOIE", NCCENR = "Haute-Savoie" },
                new Department(){ Region = 83, Dep = "63", ChefLieu = "63113", TNCC = 2, NCC = "PUY-DE-DOME", NCCENR = "Puy-de-Dôme" },
                new Department(){ Region = 83, Dep = "15", ChefLieu = "15014", TNCC = 2, NCC = "CANTAL", NCCENR = "Cantal" },
                new Department(){ Region = 83, Dep = "43", ChefLieu = "43157", TNCC = 3, NCC = "HAUTE-LOIRE", NCCENR = "Haute-Loire" },
                new Department(){ Region = 83, Dep = "03", ChefLieu = "03190", TNCC = 5, NCC = "ALLIER", NCCENR = "Allier" },
                new Department(){ Region = 91, Dep = "48", ChefLieu = "48095", TNCC = 3, NCC = "LOZERE", NCCENR = "Lozère" },
                new Department(){ Region = 91, Dep = "34", ChefLieu = "34172", TNCC = 5, NCC = "HERAULT", NCCENR = "Hérault" },
                new Department(){ Region = 91, Dep = "30", ChefLieu = "30189", TNCC = 2, NCC = "GARD", NCCENR = "Gard" },
                new Department(){ Region = 91, Dep = "11", ChefLieu = "11069", TNCC = 5, NCC = "AUDE", NCCENR = "Aude" },
                new Department(){ Region = 91, Dep = "66", ChefLieu = "66136", TNCC = 4, NCC = "PYRENEES-ORIENTALES", NCCENR = "Pyrénées-Orientales" },
                new Department(){ Region = 93, Dep = "84", ChefLieu = "84007", TNCC = 0, NCC = "VAUCLUSE", NCCENR = "Vaucluse" },
                new Department(){ Region = 93, Dep = "13", ChefLieu = "13055", TNCC = 4, NCC = "BOUCHES-DU-RHONE", NCCENR = "Bouches-du-Rhône" },
                new Department(){ Region = 93, Dep = "06", ChefLieu = "06088", TNCC = 4, NCC = "ALPES-MARITIMES", NCCENR = "Alpes-Maritimes" },
                new Department(){ Region = 93, Dep = "05", ChefLieu = "05061", TNCC = 4, NCC = "HAUTES-ALPES", NCCENR = "Hautes-Alpes" },
                new Department(){ Region = 93, Dep = "83", ChefLieu = "83137", TNCC = 2, NCC = "VAR", NCCENR = "Var" },
                new Department(){ Region = 93, Dep = "04", ChefLieu = "04070", TNCC = 4, NCC = "ALPES-DE-HAUTE-PROVENCE", NCCENR = "Alpes-de-Haute-Provence" },
                new Department(){ Region = 94, Dep = "2A", ChefLieu = "2A004", TNCC = 3, NCC = "CORSE-DU-SUD", NCCENR = "Corse-du-Sud" },
                new Department(){ Region = 94, Dep = "2B", ChefLieu = "2B033", TNCC = 3, NCC = "HAUTE-CORSE", NCCENR = "Haute-Corse" }
            };
            return departments;
        }

        /// <summary>
        /// Représente un département français
        /// </summary>
        public class Department
        {
            /// <summary>
            /// Code région
            /// </summary>
            public int Region { get; set; }
            
            /// <summary>
            /// Code département
            /// </summary>
            public string Dep { get; set; }
            
            /// <summary>
            /// Code de la commune chef-lieu
            /// </summary>
            public string ChefLieu { get; set; }
            
            /// <summary>
            /// Type de nom en clair
            /// </summary>
            public int TNCC { get; set; }
            
            /// <summary>
            /// Nom en clair (majuscules). Libellé en lettres majuscules.
            /// </summary>
            public string NCC { get; set; }
            
            /// <summary>
            /// Nom en clair (typographie riche). Libellé en typographie riche, majuscules, minuscules, accentuation.
            /// </summary>
            public string NCCENR { get; set; }
        }
    }
}
