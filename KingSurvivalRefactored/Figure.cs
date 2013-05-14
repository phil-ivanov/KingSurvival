﻿using System;

namespace KingSurvival
{
    public abstract class Figure
    {
        private Position position;
        public char symbol;

        public Figure(Position position, char symbol)
        {
            this.Position = position;
            this.Symbol = symbol;
        }

        public char Symbol
        {
            get
            {
                return this.symbol;
            }
            protected set
            {
                this.symbol = value;
            }
        }

        public Position Position
        {
            get
            {
                return this.position;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
