using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Data.Entity;
using EntityFramework.Extensions;

namespace MRM.Ibis.VirginRadioTour.Core.DAL
{
    /// <summary>
    /// Représente l'entrepot de données de l'entité T.
    /// </summary>
    /// <typeparam name="T">Type de l'entité.</typeparam>
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly EFDbContext _context;

        /// <summary>
        /// Initialise une nouvelle instance de la classe EntityRepository à l'aide d'un contexte.
        /// </summary>
        /// <param name="context"></param>
        public GenericRepository(EFDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Recherche un élément qui correspond aux conditions définies par le prédicat spécifié et retourne la première occurrence.
        /// </summary>
        /// <param name="match">Délégué Predicate qui définit les conditions de l'élément à rechercher.</param>
        /// <returns>Premier élément qui correspond aux conditions définies par le prédicat spécifié, s'il est trouvé ; sinon, la valeur par défaut pour le type T.</returns>
        public T Find(Expression<Func<T, bool>> match)
        {
            return _context.Set<T>().SingleOrDefault(match);
        }

        /// <summary>
        /// Récupère tous les éléments qui correspondent aux conditions définies par le prédicat spécifié.
        /// </summary>
        /// <param name="match">Délégué Predicate qui définit les conditions des éléments à rechercher.</param>
        /// <returns>List contenant tous les éléments qui correspondent aux conditions définies par le prédicat spécifié, si une correspondance est trouvée ; sinon, un IEnumerable vide.</returns>
        public List<T> FindAll(Expression<Func<T, bool>> match)
        {
            return _context.Set<T>().Where(match).ToList();
        }

        /// <summary>
        /// Recherche si un élément qui correspond aux conditions définies par le prédicat spécifié.
        /// </summary>
        /// <param name="match">Délégué Predicate qui définit les conditions de l'élément à rechercher.</param>
        /// <returns>Booléen indiquant si au moins un élément correspond aux conditions définies par le prédicat spécifié.</returns>
        public bool Any(Expression<Func<T, bool>> match)
        {
            return _context.Set<T>().Any(match);
        }

        /// <summary>
        /// Retourne le nombre d'éléments qui correspondent aux conditions définies par le prédicat spécifié.
        /// </summary>
        /// <param name="match">Délégué Predicate qui définit les conditions de l'élément à rechercher.</param>
        /// <returns>Nombre d'éléments correspondants aux conditions définies par le prédicat spécifié.</returns>
        public int Count(Expression<Func<T, bool>> match)
        {
            return _context.Set<T>().Count(match);
        }

        /// <summary>
        /// Ajoute un objet à la source de données.
        /// </summary>
        /// <param name="entity">Objet à ajouter à la source de données.</param>
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        /// <summary>
        /// Met à jour un objet de la source de données.
        /// </summary>
        /// <param name="entity">Objet à mettre à jour dans la source de données.</param>
        public void Update(T entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        /// <summary>
        /// Met à jour tous les éléments qui correspondent aux conditions définies par le prédicat spécifié.
        /// </summary>
        /// <param name="match">Délégué Predicate qui définit les conditions des éléments à mettre à jour.</param>
        /// <param name="update">Délégué Predicate qui définit les modifications des éléments à mettre à jour.</param>
        public void Update(Expression<Func<T, bool>> match, Expression<Func<T, T>> expression)
        {
            _context.BeginTransaction();
            _context.Set<T>().Where(match).Update(expression);
        }

        /// <summary>
        /// Met à jour tous les éléments qui correspondent aux conditions définies par le prédicat spécifié.
        /// </summary>
        /// <param name="match">Délégué Predicate qui définit les conditions des éléments à mettre à jour.</param>
        public void Update(Expression<Func<T, T>> expression)
        {
            _context.BeginTransaction();
            _context.Set<T>().Update(expression);
        }

        /// <summary>
        /// Supprime la première occurrence d'un objet spécifique de la source de données.
        /// </summary>
        /// <param name="entity">Objet à supprimer de la source de données.</param>
        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        /// <summary>
        /// Supprime tous les éléments qui correspondent aux conditions définies par le prédicat spécifié.
        /// </summary>
        /// <param name="match">Délégué Predicate qui définit les conditions des éléments à supprimer.</param>
        public void Delete(Expression<Func<T, bool>> match)
        {
            _context.BeginTransaction();
            _context.Set<T>().Where(match).Delete();
        }
    }
}
