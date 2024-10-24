﻿using DAL.Interfaces;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class DALGenericoImpl<TEntity> : IDALGenerico<TEntity> where TEntity : class
    {

        private ProyectoWebAvanzadaContext _proyectoWebAvanzada;

        public DALGenericoImpl(ProyectoWebAvanzadaContext proyectoWebAvanzada)
        {

            _proyectoWebAvanzada = proyectoWebAvanzada;
        }

        public bool Add(TEntity entity)
        {
            try
            {
                _proyectoWebAvanzada.Add(entity);
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public TEntity Get(int id)
        {

            return _proyectoWebAvanzada.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _proyectoWebAvanzada.Set<TEntity>().ToList();
        }

        public bool Remove(TEntity entity)
        {
            try
            {
                _proyectoWebAvanzada.Set<TEntity>().Attach(entity);
                _proyectoWebAvanzada.Set<TEntity>().Remove(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(TEntity entity)
        {
            try
            {
                _proyectoWebAvanzada.Entry(entity).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}