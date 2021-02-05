namespace TestCodeFirst
{
    using DataContext;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class ТехнологическаяУстановка : Установка
    {
        public ТехнологическаяУстановка() : base() {}
        public ТехнологическаяУстановка(
            string марка,
            string модель,
            string описание,
            DateTime датаВыпуска) 
            : base(
                  марка, 
                  модель, 
                  описание, 
                  датаВыпуска)
        {
            this.СиловойАгрегатВУстройстве = new ObservableCollection<СиловойАгрегатВУстановке>();
            this.РежимыРаботыУстановки = new ObservableCollection<РежимРаботыУстановки>();
        }

        /// <summary>
        /// Список ресурсов, которые использует установка.
        /// </summary>
        //public virtual ObservableCollection<УстановкаРежимРесурс> УстройствоРежимРесурс { get; set; }
        //public virtual ObservableCollection<СправочникРесурсов> Ресурсы { get; set; }

        //public virtual ObservableCollection<РежимРаботыАгрегата> РежимыРаботыУстановки { get; set; }

        public virtual ObservableCollection<ДневнаяНормаНаУстановку> ДневнаяНормаНаУстановку { get; set; }
        public virtual ObservableCollection<РежимРаботыУстановки> РежимыРаботыУстановки { get; set; }
        public virtual ObservableCollection<СиловойАгрегатВУстановке> СиловойАгрегатВУстройстве { get; set; }
    }
}
