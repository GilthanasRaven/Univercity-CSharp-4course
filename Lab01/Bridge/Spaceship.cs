using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01.Bridge
{
    //Абстрактный класс - космический корабль
    abstract class Spaceship
    {
        //Объекты интерфейса реализатора - запчасти
        //Задаем список объектов интерфейса
        protected List<IPart> _parts;
        //Метод доступа к объектам интерфейса
        public List<IPart> Parts { get {return _parts;} set {_parts = value;} }

        //Пустой конструктор
        public Spaceship() => _parts = new List<IPart>();
        //Конструктор списка объектов интерфейса реализатора
        public Spaceship(List<IPart> Parts) => _parts = Parts;
    }

    //Уточняющая абстракция - корвет
    class Corvette : Spaceship
    {
        //Копируем пустой конструктор
        public Corvette() : base() {}
        //Копируем старый конструктор интерфейса реализатора
        public Corvette(List<IPart> Parts) : base(Parts) {}
    }

    //Уточняющая абстракция - эсминец
    class Destroyer : Spaceship
    {
        //Копируем пустой конструктор
        public Destroyer() : base() {}
        //Копируем старый конструктор интерфейса реализатора
        public Destroyer(List<IPart> Parts) : base(Parts) {}
    }

    //Уточняющая абстракция - крейсер
    class Cruiser : Spaceship
    {
        //Копируем пустой конструктор
        public Cruiser() : base() {}
        //Копируем старый конструктор интерфейса реализатора
        public Cruiser(List<IPart> Parts) : base(Parts) {}
    }

    //Уточняющая абстракция - линкор
    class Battleship : Spaceship
    {
        //Копируем пустой конструктор
        public Battleship() : base() {}
        //Копируем старый конструктор интерфейса реализатора
        public Battleship(List<IPart> Parts) : base(Parts) {}
    }

    //Уточняющая абстракция - титан
    class Titan : Spaceship
    {
        //Копируем пустой конструктор
        public Titan() : base() {}
        //Копируем старый конструктор интерфейса реализатора
        public Titan(List<IPart> Parts) : base(Parts) {}
    }
}
