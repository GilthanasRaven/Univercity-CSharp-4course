using System;
using System.Collections.Generic;
using System.Text;

using Lab01.Bridge;

namespace Lab01.Builder
{
    //Интерфейс строителя
    interface ISpaceshipBuilder
    {
        //Собрать двигатель
        public void BuildEngine(Engine part);
        //Собрать радар
        public void BuildRadar(Radar part);
        //Собрать оружие
        public void BuildWeapon(Weapon part);
        //Собрать корпус
        public void BuildHull(Hull part);
        //Собрать щиты
        public void BuildShield(Shield part);
        //Сборка
        public void Construct();
        //Получить собранный объект и сделать переход
        public Spaceship GetProduct();
    }

    //Строитель корветов
    class CorvetteBuilder : ISpaceshipBuilder
    {
        //===Интерфейс===
        //=Методы=
        //Собрать двигатель
        public void BuildEngine(Engine part)
        {
            _corvette.Parts.Add(part);
        }
        //Собрать радар
        public void BuildRadar(Radar part)
        {
            _corvette.Parts.Add(part);
        }
        //Собрать оружие
        public void BuildWeapon(Weapon part)
        {
            _corvette.Parts.Add(part);
        }
        //Собрать корпус
        public void BuildHull(Hull part)
        {
            _corvette.Parts.Add(part);
        }
        //Собрать щиты
        public void BuildShield(Shield part)
        {
            _corvette.Parts.Add(part);
        }

        //===Класс===
        //=Поля=
        //Объект итогового продукта - корвет
        private Corvette _corvette;

        //=Конструкторы=
        //Пустой конструктор
        public CorvetteBuilder()
        {
            Construct();
        }

        //=Методы=
        //Переход на сборку нового объекта
        public void Construct()
        {
            _corvette = new Corvette();
        }

        //Получить собранный объект и сделать переход
        public Spaceship GetProduct()
        {
            return _corvette;
        }
    }
}
