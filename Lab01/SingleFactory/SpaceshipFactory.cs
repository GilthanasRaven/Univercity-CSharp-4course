using System;
using System.Collections.Generic;
using System.Text;

using Lab01.Bridge;
using Lab01.Builder;

namespace Lab01.SingleFactory
{
    abstract class SpaceshipFactory
    {
        //Директор фабрики
        private SpaceshipDirector _director;
        //Метод доступа к объекту директора
        public SpaceshipDirector Director { get { return _director; } set { _director = value; } }

        //Построить корвет
        abstract public Corvette CreateCorvette();
    }

    class CorvetteSingleFactory : SpaceshipFactory
    {
        //===Одиночка===
        //Объект
        private static CorvetteSingleFactory instance;

        //Пустой конструктор
        public CorvetteSingleFactory() {}

        //Получить объект
        public static CorvetteSingleFactory getInstance()
        {
            if (instance == null)
            { 
                instance = new CorvetteSingleFactory();
            }
            return instance;
        }

        //===Фабрика===
        private CorvetteDirector _director = new CorvetteDirector();

        public override Corvette CreateCorvette()
        {
            CorvetteBuilder builder = new CorvetteBuilder();
            _director.Builder = builder;
            _director.BuildFullCorvette();
            Corvette result = (Corvette)builder.GetProduct();
            return result;
        }
    }
}
