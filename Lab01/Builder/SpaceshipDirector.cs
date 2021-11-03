using System;
using System.Collections.Generic;
using System.Text;

using Lab01.Bridge;

namespace Lab01.Builder
{
    abstract class SpaceshipDirector
    {
        //Объект интерфейса строителя
        private ISpaceshipBuilder _builder;
        //Метод доступа к строителю
        public ISpaceshipBuilder Builder { get {return _builder;} set {_builder = value;} }

        //Пустой конструктор
        public SpaceshipDirector() {}
        //Конструктор строителя
        public SpaceshipDirector(ISpaceshipBuilder Builder) => _builder = Builder;
    }

    class CorvetteDirector : SpaceshipDirector
    {
        //Копируем пустой конструктор
        public CorvetteDirector() : base() {}
        //Копируем старый конструктор строителя
        public CorvetteDirector(CorvetteBuilder Builder) : base(Builder) {}

        //Корабль-пацифист
        public void BuildPacifistCorvette()
        {
            Builder.Construct();
            Builder.BuildEngine(PartsDatabase.HOLE52);
            Builder.BuildRadar(PartsDatabase.MONTY43);
            Builder.BuildHull(PartsDatabase.MARK2);
        }

        //Полная сборка
        public void BuildFullCorvette()
        {
            Builder.Construct();
            Builder.BuildEngine(PartsDatabase.HOLE52);
            Builder.BuildRadar(PartsDatabase.MONTY43);
            Builder.BuildHull(PartsDatabase.MARK2);
            Builder.BuildShield(PartsDatabase.PsychoShield);
            Builder.BuildWeapon(PartsDatabase.BlueLaser);
        }
    }
}
