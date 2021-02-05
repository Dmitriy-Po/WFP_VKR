using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCodeFirst.DataContext;

namespace TestCodeFirst.WorkWithCollection
{
    [NotMapped]
    public class WorkCollection
    {
        private static ObservableCollection<T> GetCollection<T>(IEnumerable<T> collections)
        {
            ObservableCollection<T> localCollection = new ObservableCollection<T>();
            foreach (var item in collections)
            {
                localCollection.Add(item);
            }

            return localCollection;
        }

        public static ObservableCollection<T> GetРежимыРаботыУстановки<T>(CodeFirstContext context)
            where T : РежимРаботыУстановки
        {
            return GetCollection(context.РежимРаботыУстановкиSet.Local.Cast<T>());
        }

        public static ObservableCollection<T> GetДневнаяНормаНаУстановку<T>(CodeFirstContext context)
            where T : ДневнаяНормаНаУстановку
        {
            return GetCollection(context.ДневнаяНормаНаУстановкуSet.Local.Cast<T>());
        }

        public static ObservableCollection<T> GetСправочникРесурсов<T>(CodeFirstContext context)
            where T : СправочникРесурсов
        {
            return GetCollection(context.СправочникРесурсовSet.Local.Cast<T>());
        }

        public static ObservableCollection<T> GetУстановкаРежимРесурс<T>(CodeFirstContext context)
            where T : УстановкаРежимРесурс
        {
            return GetCollection(context.УстройствоРежимРесурсSet.Local.Cast<T>());
        }

        public static ObservableCollection<T> GetПланПоМесяцам<T>(CodeFirstContext context)
            where T : ПланПроизводстваПоМесяцам
        {
            return GetCollection(context.ПланПроизводстваПоМесяцамSet.Local.Cast<T>());
        }

        public static ObservableCollection<T> GetПланНормативныйТехнологический<T>(CodeFirstContext context)
            where T : ПланНормативныйТехнологический
        {
            return GetCollection(context.СправочникSet.Local.Cast<T>());
        }

        public static ObservableCollection<T> GetТехнологическоеУстройство<T>(CodeFirstContext context)
            where T : ТехнологическаяУстановка
        {
            return GetCollection(context.УстановкаSet.Local.Cast<T>());
        }

        public static ObservableCollection<T> GetСиловойАгрегатВУстановке<T>(CodeFirstContext context)
            where T : СиловойАгрегатВУстановке
        {
            return GetCollection(context.СиловойАгрегатВУстройствеSet.Local.ToBindingList().Cast<T>());
        }

        public static ObservableCollection<T> GetРежимРаботы<T>(CodeFirstContext context)
            where T : РежимРаботыАгрегата
        {
            return GetCollection(context.РежимРаботыАгрегатаSet.Local.ToBindingList().Cast<T>());
        }

        public static ObservableCollection<T> GetФактическоеПотребление<T>(CodeFirstContext context)
            where T : ФактическоеПотребление
        {
            return GetCollection(context.ФактическоеПотреблениеSet.Local.ToBindingList().Cast<T>());
        }

        /// <summary>
        /// Функция определяет событие, произошедшее с элементом списка: добавлен или удалён. 
        /// Также производит сохранение.
        /// </summary>
        /// <typeparam name="T">Тип объектов в коллекции.</typeparam>
        /// <param name="context">Контекст для сохранения данных.</param>
        /// <param name="e">Произошедшее событие.</param>
        public static void ItemCollectionChanged<T>(CodeFirstContext context, NotifyCollectionChangedEventArgs e)
            where T: class
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    context.Set<T>().AddRange(e.NewItems.Cast<T>());
                    break;
                case NotifyCollectionChangedAction.Remove:
                    context.Set<T>().RemoveRange(e.OldItems.Cast<T>());
                    break;
                default:
                    break;
            }

            context.SaveChanges();
        }

        
    }
}
