using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FirstOOP
{
    public class Kuh
    {
        string _name;
        string _colour;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }


        public Kuh(string name, string colour)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new InvalidDataException();
            }

            _name = name;
            _colour = colour;
        }

    }