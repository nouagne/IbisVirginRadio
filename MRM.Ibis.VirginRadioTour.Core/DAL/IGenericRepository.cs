using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MRM.Ibis.VirginRadioTour.Core.DAL
{
    /// <summary>
    /// Définit des méthodes pour manipuler les entités de type T.
    /// </summary>
    /// <typeparam name="T">Type de l'entité.</typeparam>
    public interface IGenericRepository<T>
    {
        /// <summary>
        /// Recherche un élément qui correspond aux conditions définies par le prédicat spécifié et retourne la première occurrence.
        /// </summary>
        /// <param name="match">Délégué Predicate qui définit les conditions de l'élément à rechercher.</param>
        /// <returns>Premier élément qui correspond aux conditions définies par le prédicat spécifié, s'il est trouvé ; sinon, la valeur par défaut pour le type T.</returns>
        T Find(Expression<Func<T, bool>> match);

        /// <summary>
        /// Récupère tous les éléments qui correspondent aux conditions définies par le prédicat spécifié.
        /// </summary>
        /// <param name="match">Délégué Predicate qui définit les conditions des éléments à rechercher.</param>
        /// <returns>List contenant tous les éléments qui correspondent aux conditions définies par le prédicat spécifié, si une correspondance est trouvée ; sinon, un IEnumerable vide.</returns>
        List<T> FindAll(Expression<Func<T, bool>> match);

        /// <summary>
        /// Recherche si un élément qui correspond aux conditions définies par le prédicat spécifié.
        /// </summary>
        /// <param name="match">Délégué Predicate qui définit les conditions de l'élément à rechercher.</param>
        /// <returns>Booléen indiquant si au moins un élément correspond aux conditions définies par le prédicat spécifié.</returns>
        bool Any(Expression<Func<T, bool>> match);

        /// <summary>
        /// Retourne le nombre d'éléments qui correspondent aux conditions définies par le prédicat spécifié.
        /// </summary>
        /// <param name="match">Délégué Predicate qui définit les conditions de l'élément à rechercher.</param>
        /// <returns>Nombre d'éléments correspondants aux conditions définies par le prédicat spécifié.</returns>
        int Count(Expression<Func<T, bool>> match);

        /// <summary>
        /// Ajoute un objet à la source de données.
        /// </summary>
        /// <param name="entity">Objet à ajouter à la source de données.</param>
        void Add(T entity);

        /// <summary>
        /// Met à jour un objet de la source de données.
        /// </summary>
        /// <param name="entity">Objet à mettre à jour dans la source de données.</param>
        void Update(T entity);

        /// <summary>
        /// Met à jour tous les éléments qui correspondent aux conditions définies par le prédicat spécifié.
        /// </summary>
        /// <param name="match">Délégué Predicate qui définit les conditions des éléments à mettre à jour.</param>
        /// <param name="update">Délégué Predicate qui définit les modifications des éléments à mettre à jour.</param>
        void Update(Expression<Func<T, bool>> match, Expression<Func<T, T>> update);

        /// <summary>
        /// Met à jour tous les éléments qui correspondent aux conditions définies par le prédicat spécifié.
        /// </summary>
        /// <param name="match">Délégué Predicate qui définit les conditions des éléments à mettre à jour.</param>
        void Update(Expression<Func<T, T>> update);

        /// <summary>
        /// Supprime la première occurrence d'un objet spécifique de la source de données.
        /// </summary>
        /// <param name="entity">Objet à supprimer de la source de données.</param>
        void Remove(T entity);

        /// <summary>
        /// Supprime tous les éléments qui correspondent aux conditions définies par le prédicat spécifié.
        /// </summary>
        /// <param name="match">Délégué Predicate qui définit les conditions des éléments à supprimer.</param>
        void Delete(Expression<Func<T, bool>> match);
    }
}
