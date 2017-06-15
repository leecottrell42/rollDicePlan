using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;


namespace RollDicePlan
{

    public class Die
    {
        static Random roller = new Random();
        private static int _dieValue;
        private static int _maxSize;
        public Die()
        {
            _dieValue = 1;
            _maxSize = 6;
        }

        public Die(int DieValue, int MaxSize)
        {
            _dieValue = DieValue;
            _maxSize = MaxSize;
        }

        public int Value
        {
            get { return _dieValue; }
            set
            {
                if (value > 0 && value <= _maxSize)
                { _dieValue = value; }
            }
        }



        public int DieSize
        {
            get { return _maxSize; }
            set
            {
                if (value > 0 && value <= 100)
                { _maxSize = value; }
            }
        }

        public int RollDie()
        {
            _dieValue = roller.Next(1, _maxSize + 1);
            return _dieValue;
        }


        
        public Uri DieImage()
        {
            Uri theImage;
            switch (_dieValue)
            {
                case 1:
                    theImage = new Uri("pack://application:,,,/RollDicePlan/component/one.png");
                    break;
                case 2:
                    theImage = new Uri("pack://application:,,,/RollDicePlan/component/two.png");
                    break;
                case 3:
                    theImage = new Uri("pack://application:,,,/RollDicePlan/component;bin/debug/3.png");
                    break;
                case 4:
                    theImage = new Uri("pack://application:,,,/RollDicePlan/component/four.png");
                    break;
                case 5:
                    theImage = new Uri("pack://application:,,,/RollDicePlan/component/five.png");
                    break;
                case 6:
                    theImage = new Uri("pack://application:,,,/RollDicePlan/component/one.png");
                    break;
                default:         
                    theImage = new Uri("pack://application:,,,/RollDicePlan/component/allDice.png");
                    break;
            }
            return theImage;
        }
    }
       
    }
