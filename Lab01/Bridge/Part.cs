using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01.Bridge
{
    //Интерфейс реализатора - запчасть корабля
    interface IPart
    {
        //Название
        string Name { get; set; }
        //Энергопотребление
        double EnergyConsume { get; set; }
        //Прочность
        double Health { get; set; }
    }

    //Конкретный реализатор - двигатель
    class Engine : IPart
    {
        //===Интерфейс===
        //Название
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }
        //Энергопотребление
        private double _energyconsume;
        public double EnergyConsume { get {return _energyconsume;} set {_energyconsume = value;} }
        //Здоровье
        private double _health;
        public double Health { get {return _energyconsume;} set {_energyconsume = value;} }

        //===Класс===
        //Конструктор параметров
        public Engine(string Name, double EnergyConsume, double Health, double Speed)
        {
            _name = Name;
            _energyconsume = EnergyConsume;
            _health = Health;
            _speed = Speed;
        }
        //Скорость
        private double _speed;
        public double Speed { get {return _speed;} set {_speed = value;} }
    }

    //Конкретный реализатор - радар
    class Radar : IPart
    {
        //===Интерфейс===
        //Название
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }
        //Энергопотребление
        private double _energyconsume;
        public double EnergyConsume { get { return _energyconsume; } set { _energyconsume = value; } }
        //Здоровье
        private double _health;
        public double Health { get { return _energyconsume; } set { _energyconsume = value; } }

        //===Класс===
        //Конструктор параметров
        public Radar(string Name, double EnergyConsume, double Health, double Range)
        {
            _name = Name;
            _energyconsume = EnergyConsume;
            _health = Health;
            _range = Range;
        }
        //Дальность
        private double _range;
        public double Range { get { return _range; } set { _range = value; } }
    }

    //Конкретный реализатор - оружие
    class Weapon : IPart
    {
        //===Интерфейс===
        //Название
        private string _name;
        public string Name { get {return _name;} set { _name = value; } }
        //Энергопотребление
        private double _energyconsume;
        public double EnergyConsume { get {return _energyconsume;} set {_energyconsume = value;} }
        //Здоровье
        private double _health;
        public double Health { get {return _energyconsume;} set {_energyconsume = value;} }

        //===Класс===
        //Конструктор параметров
        public Weapon(string Name, double EnergyConsume, double Health, double Damage)
        {
            _name = Name;
            _energyconsume = EnergyConsume;
            _health = Health;
            _damage = Damage;
        }
        //Повреждения
        private double _damage;
        public double Damage { get {return _damage;} set {_damage = value;} }
    }

    //Конкретный реализатор - корпус
    class Hull : IPart
    {
        //===Интерфейс===
        //Название
        private string _name;
        public string Name { get {return _name;} set {_name = value;} }
        //Энергопотребление
        private double _energyconsume;
        public double EnergyConsume { get {return _energyconsume;} set {_energyconsume = value;} }
        //Здоровье
        private double _health;
        public double Health { get {return _energyconsume;} set {_energyconsume = value;} }

        //===Класс===
        //Конструктор параметров
        public Hull(string Name, double EnergyConsume, double Health)
        {
            _name = Name;
            _energyconsume = EnergyConsume;
            _health = Health;
        }
    }

    //Конкретный реализатор - щиты
    class Shield : IPart
    {
        //===Интерфейс===
        //Название
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }
        //Энергопотребление
        private double _energyconsume;
        public double EnergyConsume { get { return _energyconsume; } set { _energyconsume = value; } }
        //Здоровье
        private double _health;
        public double Health { get { return _energyconsume; } set { _energyconsume = value; } }

        //===Класс===
        //Конструктор параметров
        public Shield(string Name, double EnergyConsume, double Health)
        {
            _name = Name;
            _energyconsume = EnergyConsume;
            _health = Health;
        }
    }
}

