using System;

namespace NombreComplexe
{
    public class NombreComplexe
    {
        private double _reel;
        private double _imaginaire;

        public NombreComplexe(double reel, double imaginaire)
        {
            _reel = reel;
            _imaginaire = imaginaire;
        }

        public void Afficher(char lettreImaginaire = 'i')
        {
            char signe;

            if (_imaginaire < 0)
                signe = '-';
            else
                signe = '+';
            
            Console.WriteLine("{0} {1} {2}{3}", _reel, signe, lettreImaginaire, Math.Abs(_imaginaire));
        }
        
        public static NombreComplexe operator +(NombreComplexe nombre1, NombreComplexe nombre2)
        {
            return new NombreComplexe
                ( nombre1._reel + nombre2._reel , nombre1._imaginaire + nombre2._imaginaire );
        }
        
        public static NombreComplexe operator +(NombreComplexe nombre1, double nombre2)
        {
            return new NombreComplexe
                ( nombre1._reel + nombre2 , nombre1._imaginaire);
        }
        
        public static NombreComplexe operator -(NombreComplexe nombre1, NombreComplexe nombre2)
        {
            return new NombreComplexe
                ( nombre1._reel - nombre2._reel , nombre1._imaginaire - nombre2._imaginaire );
        }
        
        public static NombreComplexe operator -(NombreComplexe nombre1, double nombre2)
        {
            return new NombreComplexe
                ( nombre1._reel - nombre2 , nombre1._imaginaire);
        }
        
        public static NombreComplexe operator *(NombreComplexe nombre1, NombreComplexe nombre2)
        {
            double r1, r2, i1, i2;

            r1 = nombre1._reel * nombre2._reel;
            r2 = nombre1._imaginaire * nombre2._imaginaire;
            i1 = nombre1._reel * nombre2._imaginaire;
            i2 = nombre1._imaginaire * nombre2._reel;

            r1 -= r2;
            i1 += i2;
            
            return new NombreComplexe(r1, i1);
        }
        
        public static NombreComplexe operator *(NombreComplexe nombre1, double nombre2)
        {
            return new NombreComplexe(nombre1._reel * nombre2, nombre1._imaginaire * nombre2);
        }
        
        public static NombreComplexe operator /(NombreComplexe nombre1, double nombre2)
        {
            return new NombreComplexe(nombre1._reel / nombre2, nombre1._imaginaire / nombre2);
        }

        public void AuCarre()
        {
            double reelTemp = _reel;
            _reel = _reel * _reel - _imaginaire * _imaginaire;
            _imaginaire = 2 * reelTemp * _imaginaire;
        }

        public double ProduitConjugues()
        {
            return _reel * _reel + _imaginaire * _imaginaire;
        }

        public NombreComplexe Inverse()
        {
            return Conjugue() / ProduitConjugues();
        }

        public NombreComplexe Conjugue()
        {
            return new NombreComplexe(_reel, - _imaginaire);
        }

        public double Module()
        {
            return Math.Sqrt(_reel * _reel + _imaginaire * _imaginaire);
        }

        public double Reel => _reel;

        public double Imaginaire => _imaginaire;
    }
}