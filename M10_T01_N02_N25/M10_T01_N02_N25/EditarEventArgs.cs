using System;

//-----------------------------------------------------------
namespace M10_T01_N02_N25
{
    //-----------------------------------------------------------
    public class EditarEventArgs : EventArgs
    {
        //-----------------------------------------------------------
        public Pessoa Pessoa { get; }
        public int Index { get; }
        public double Peso { get; }

        //-----------------------------------------------------------
        public EditarEventArgs(Pessoa pessoa, int index)
        {
            Pessoa = pessoa;
            Index = index;
        }

        //-----------------------------------------------------------
        public EditarEventArgs(Pessoa pessoa, int index, double peso)
        {
            Pessoa = pessoa;
            Index = index;
            Peso = peso;
        }
    }
}
