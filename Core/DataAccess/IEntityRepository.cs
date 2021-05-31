
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint - jenerik kısıtı T yerin girilebilecekleri ayarlamak
    //class referans tip olabilir demek
    //T yerine ya IeEntity ya da IEntity e implente bir class olmalı
    //new():newlenebilir olmalı-->IEntity newlenemez
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //Filtreler yazabilmemizi sağlıyor.-->Expression<Func<T,bool>> filter
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        //Bir tane getirmesini istediğimizde filtre zorunludur.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
