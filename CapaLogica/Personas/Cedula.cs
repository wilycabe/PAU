namespace CapaLogica.Personas
{
    internal class Cedula
    {

        internal static bool VerificaIdentificacion(string identificacion)
        {
            if (identificacion.Length < 10) return false;
            var valced = identificacion.Trim().ToCharArray();
            var provincia = int.Parse((valced[0] + valced[1].ToString()));
            if (provincia <= 0 || provincia >= 25) return false;
            var estado = false;
            if (int.Parse(valced[2].ToString()) < 6)
            {
                estado = VerificaCedula(valced);
            }
            else switch (int.Parse(valced[2].ToString()))
            {
                case 6:
                    estado = VerificaSectorPublico(valced);
                    break;
                case 9:
                    estado = VerificaPersonaJuridica(valced);
                    break;
            }
            return estado;
        }

        public static bool VerificaCedula(char[] validarCedula)
        {
            int aux, par = 0, impar = 0;
            for (var i = 0; i < 9; i += 2)
            {
                aux = 2 * int.Parse(validarCedula[i].ToString());
                if (aux > 9)
                    aux -= 9;
                par += aux;
            }
            for (var i = 1; i < 9; i += 2)
            {
                impar += int.Parse(validarCedula[i].ToString());
            }

            aux = par + impar;
            var verifi = aux % 10 != 0 ? 10 - (aux % 10) : 0;
            return verifi == int.Parse(validarCedula[9].ToString());
        }

        public static bool VerificaPersonaJuridica(char[] validarCedula)
        {
            var aux = 0;
            var veri = int.Parse(validarCedula[10].ToString()) + int.Parse(validarCedula[11].ToString()) + int.Parse(validarCedula[12].ToString());
            if (veri <= 0) return false;
            int[] coeficiente = { 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            for (var i = 0; i < 9; i++)
            {
                var prod = int.Parse(validarCedula[i].ToString()) * coeficiente[i];
                aux += prod;
            }
            switch (aux % 11)
            {
                case 0:
                    veri = 0;
                    break;
                case 1:
                    return false;
                default:
                    aux %= 11;
                    veri = 11 - aux;
                    break;
            }
            return veri == int.Parse(validarCedula[9].ToString());
        }

        public static bool VerificaSectorPublico(char[] validarCedula)
        {
            var aux = 0;
            var veri = int.Parse(validarCedula[9].ToString())
                       + int.Parse(validarCedula[10].ToString())
                       + int.Parse(validarCedula[11].ToString())
                       + int.Parse(validarCedula[12].ToString());
            if (veri <= 0) return false;
            int[] coeficiente = {3, 2, 7, 6, 5, 4, 3, 2};
            for (var i = 0; i < 8; i++)
            {
                var prod = int.Parse(validarCedula[i].ToString()) * coeficiente[i];
                aux += prod;
            }
            switch (aux % 11)
            {
                case 0:
                    veri = 0;
                    break;
                case 1:
                    return false;
                default:
                    aux %= 11;
                    veri = 11 - aux;
                    break;
            }
            return veri == int.Parse(validarCedula[8].ToString());
        }

    }
}
