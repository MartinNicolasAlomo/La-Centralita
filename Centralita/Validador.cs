﻿using EspacioCentralita;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public static class Validador
    {

        public static bool ValidarTelefonoIngresado(ref string datoIngresado, byte cantidadCaracteresPermitidos, out bool esProvincial)
        {
            esProvincial = false;   //  Local
            return !VerificarEsDatoVacio(datoIngresado) && datoIngresado.Length <= cantidadCaracteresPermitidos && VerificarEsTelefono(ref datoIngresado, out esProvincial);
        }

        public static bool VerificarEsTelefono(ref string nombre, out bool esProvicial)
        {
            esProvicial = false;
            for (int i = 0; i < nombre.Length && nombre[i] != '\0'; i++)
            {
                if (i == 0 && nombre[0] == '#')
                {
                    esProvicial = true;
                }
                if (i > 0 && !char.IsNumber(nombre[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool VerificarEsDatoVacio(string datoIngresado)
        {
            datoIngresado = datoIngresado.Trim();
            return string.IsNullOrEmpty(datoIngresado) || string.IsNullOrWhiteSpace(datoIngresado);
        }

        public static int CrearNumeroAleatorio(int valorMin, int valorMax)
        {
            Random random = new Random();
            int numeroRandom = random.Next(valorMin, valorMax + 1);
            return numeroRandom;
        }

        public static float CrearNumeroAleatorio()
        {
            Random random = new Random();
            float numeroRandom = (float)random.NextDouble();
            return numeroRandom;
        }




        public static bool ValidarTextoNumerico(string datoIngresado, byte cantidadCaracteresPermitidos)
        {
            return !VerificarEsDatoVacio(datoIngresado) && datoIngresado.Length == cantidadCaracteresPermitidos && VerificarEsNumero(datoIngresado);
        }

        public static bool VerificarEsNumero(string datoIngresado)
        {
            for (int i = 0; i < datoIngresado.Length && datoIngresado[i] != '\0'; i++)
            {
                if (datoIngresado[i] < '0' || datoIngresado[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }


        public static bool ValidarNumeroIngresado(out decimal numero, string datoIngresado, decimal minimo, decimal maximo)
        {
            numero = 0;
            return !VerificarEsDatoVacio(datoIngresado) && decimal.TryParse(datoIngresado, out numero) && ValidarRangoNumero(numero, minimo, maximo);
        }

        public static bool ValidarRangoNumero(decimal numero, decimal minimo, decimal maximo)
        {
            if (minimo <= maximo && numero >= minimo && numero <= maximo)
            {
                return true;
            }
            return false;
        }


        public static bool ValidarNumeroIngresado(out ulong numero, string datoIngresado, ulong minimo, ulong maximo)
        {
            numero = 0;
            return !VerificarEsDatoVacio(datoIngresado) && ulong.TryParse(datoIngresado, out numero) && ValidarRangoNumero(numero, minimo, maximo);
        }

        public static bool ValidarRangoNumero(ulong numero, ulong minimo, ulong maximo)
        {
            if (minimo <= maximo && numero >= minimo && numero <= maximo)
            {
                return true;
            }
            return false;
        }


        public static bool ValidarNumeroIngresado(out byte numero, string datoIngresado, byte minimo, byte maximo)
        {
            numero = 0;
            return !VerificarEsDatoVacio(datoIngresado) && byte.TryParse(datoIngresado, out numero) && ValidarRangoNumero(numero, minimo, maximo);
        }

        public static bool ValidarRangoNumero(byte numero, byte minimo, byte maximo)
        {
            if (minimo <= maximo && numero >= minimo && numero <= maximo)
            {
                return true;
            }
            return false;
        }


        public static bool ValidarNumeroIngresado(out ushort numero, string datoIngresado, ushort minimo, ushort maximo)
        {
            numero = 0;
            return !VerificarEsDatoVacio(datoIngresado) && ushort.TryParse(datoIngresado, out numero) && ValidarRangoNumero(numero, minimo, maximo);
        }

        public static bool ValidarRangoNumero(ushort numero, ushort minimo, ushort maximo)
        {
            if (minimo <= maximo && numero >= minimo && numero <= maximo)
            {
                return true;
            }
            return false;
        }


        public static bool ValidarNombreIngresado(ref string datoIngresado, byte cantidadCaracteresPermitidos)
        {
            return !VerificarEsDatoVacio(datoIngresado) && datoIngresado.Length <= cantidadCaracteresPermitidos && VerificarEsNombre(ref datoIngresado);
        }

        public static bool VerificarEsNombre(ref string nombre)
        {
            for (int i = 0; i < nombre.Length && nombre[i] != '\0'; i++)
            {
                if (!VerificarEsCaracterNombre(nombre[i]))
                {
                    return false;
                }
            }
            nombre = PasarInicialesNombreAMayusculas(nombre);
            return true;
        }

        public static bool VerificarEsCaracterNombre(char caracter)
        {
            if ((caracter != ' ') && (caracter != '-') &&
                (caracter < 'a' || caracter > 'z') &&
                (caracter < 'A' || caracter > 'Z') &&
                (caracter != 'ñ') && (caracter != 'Ñ') && (caracter != 'ç') && (caracter != 'Ç') &&
                (caracter != 'á') && (caracter != 'é') && (caracter != 'í') && (caracter != 'ó') && (caracter != 'ú') &&
                (caracter != 'Á') && (caracter != 'É') && (caracter != 'Í') && (caracter != 'Ó') && (caracter != 'Ú') &&
                (caracter != 'ä') && (caracter != 'ë') && (caracter != 'ï') && (caracter != 'ö') && (caracter != 'ü') &&
                (caracter != 'Ä') && (caracter != 'Ë') && (caracter != 'Ï') && (caracter != 'Ö') && (caracter != 'Ü'))
            {
                return false;
            }
            return true;
        }




        public static bool ValidarDireccionIngresada(ref string datoIngresado, byte cantidadCaracteresPermitidos)
        {
            return !VerificarEsDatoVacio(datoIngresado) && datoIngresado.Length <= cantidadCaracteresPermitidos && VerificarEsDireccion(ref datoIngresado);
        }

        public static bool VerificarEsDireccion(ref string nombre)
        {
            for (int i = 0; i < nombre.Length && nombre[i] != '\0'; i++)
            {
                if (!VerificarEsCaracterDireccion(nombre[i]))
                {
                    return false;
                }
            }
            nombre = PasarInicialesNombreAMayusculas(nombre);
            return true;
        }

        public static bool VerificarEsCaracterDireccion(char caracter)
        {
            if ((caracter != ' ') && (caracter != '-') && (caracter != '.') &&
                (caracter < 'a' || caracter > 'z') &&
                (caracter < 'A' || caracter > 'Z') &&
                (caracter < '0' || caracter > '9') &&
                (caracter != 'ñ') && (caracter != 'Ñ') && (caracter != 'ç') && (caracter != 'Ç') &&
                (caracter != 'á') && (caracter != 'é') && (caracter != 'í') && (caracter != 'ó') && (caracter != 'ú') &&
                (caracter != 'Á') && (caracter != 'É') && (caracter != 'Í') && (caracter != 'Ó') && (caracter != 'Ú') &&
                (caracter != 'ä') && (caracter != 'ë') && (caracter != 'ï') && (caracter != 'ö') && (caracter != 'ü') &&
                (caracter != 'Ä') && (caracter != 'Ë') && (caracter != 'Ï') && (caracter != 'Ö') && (caracter != 'Ü'))
            {
                return false;
            }
            return true;
        }


        public static string PasarInicialesNombreAMayusculas(string auxNombre)
        {
            string nombreProvisorio = PasarTodasLetrasNombreAMinusculas(auxNombre);
            int largo = nombreProvisorio.Length;
            int i = 0;
            char letraInicial;
            string seccionInicial;
            char primeraLetraNombre;
            string seccionPrevia;
            string seccionSiguiente;
            do
            {
                if (i == 0)
                {
                    seccionInicial = nombreProvisorio.Substring(i + 1);
                    letraInicial = char.ToUpper(nombreProvisorio[i]);
                    nombreProvisorio = string.Concat(letraInicial, seccionInicial);
                    i++;
                    if (largo == 1)
                    {
                        break;
                    }
                }
                if (nombreProvisorio[i].Equals(' ') || nombreProvisorio[i].Equals('-'))
                {
                    seccionPrevia = nombreProvisorio.Substring(0, i);
                    primeraLetraNombre = nombreProvisorio[i + 1];
                    primeraLetraNombre = char.ToUpper(primeraLetraNombre);
                    seccionSiguiente = nombreProvisorio.Substring(i + 2);
                    if (nombreProvisorio[i].Equals(' '))
                    {
                        nombreProvisorio = string.Concat(seccionPrevia, " ", primeraLetraNombre.ToString(), seccionSiguiente);
                        i++;
                    }
                    else
                    {
                        nombreProvisorio = string.Concat(seccionPrevia, "-", primeraLetraNombre.ToString(), seccionSiguiente);
                        i++;
                    }
                }
                i++;
            } while (i + 2 < largo);
            return nombreProvisorio;
        }

        public static string PasarTodasLetrasNombreAMinusculas(string auxNombre)
        {
            string nombreProvisorio = string.Empty;
            char letraNombre;
            for (int i = 0; i < auxNombre.Length; i++)
            {
                if (i != ' ' || i != '-')
                {
                    letraNombre = auxNombre[i];
                    nombreProvisorio += char.ToLower(letraNombre);
                }
                else
                {
                    nombreProvisorio += auxNombre[i];
                }
            }
            return nombreProvisorio;
        }

        public static string PasarTodasLetrasNombreAMayusculas(string auxNombre)
        {
            string nombreProvisorio = string.Empty;
            char letraNombre;
            for (int i = 0; i < auxNombre.Length; i++)
            {
                if (i != ' ' || i != '-')
                {
                    letraNombre = auxNombre[i];
                    nombreProvisorio += char.ToUpper(letraNombre);
                }
                else
                {
                    nombreProvisorio += auxNombre[i];
                }
            }
            return nombreProvisorio;
        }


        public static bool ValidarEmailIngresado(string datoIngresado)
        {
            return !VerificarEsDatoVacio(datoIngresado) && VerificarEsEmailValido(ref datoIngresado);
        }

        public static bool VerificarEsEmailValido(ref string email)
        {
            for (int i = 0; i < email.Length && email[i] != '\0'; i++)
            {
                if (!VerificarEsCaracterEmail(email[i]))
                {
                    return false;
                }
            }
            if (!email.Contains("@gmail.com") && !email.Contains("@gmail.com.ar") && !email.Contains("@hotmail.com") && !email.Contains("@hotmail.com.ar") &&
                !email.Contains("@outlook.com") && !email.Contains("@outlook.es") && !email.Contains("@yahoo.com") && !email.Contains("@protonmail.com"))
            {
                return false;
            }
            return true;
        }

        public static bool VerificarEsCaracterEmail(char caracter)
        {
            if ((caracter < 'a' || caracter > 'z') &&
                (caracter < 'A' || caracter > 'Z') &&
                (caracter < '0' || caracter > '9') &&
                (caracter != '.') && (caracter != '-') && (caracter != '+') && (caracter != '_') && (caracter != '~') && (caracter != '@'))
            {
                return false;
            }
            return true;
        }

        public static bool ValidarClaveIngresada(string datoIngresado)
        {
            return !VerificarEsDatoVacio(datoIngresado) && VerificarEsClaveValida(ref datoIngresado);
        }

        public static bool VerificarEsClaveValida(ref string clave)
        {
            for (int i = 0; i < clave.Length && clave[i] != '\0'; i++)
            {
                if (!VerificarEsCaracterEmail(clave[i]))
                {
                    return false;
                }
            }
            return true;
        }


        public static bool ValidarFechaIngresada(out DateTime fechaFinal, string anioIngresado, string mesIngresado, string diaIgresado)
        {
            if (ValidarNumeroIngresado(out ushort anioFinal, anioIngresado, 1905, 2005))
            {
                byte MesFinal;
                byte diaFinal;
                bool esBisiesto = VerificarEsAnioBisiesto(anioFinal);
                if (ValidarNumeroIngresado(out MesFinal, mesIngresado, 1, 12) &&
                        (MesFinal == 2 &&
                        (esBisiesto && ValidarNumeroIngresado(out diaFinal, diaIgresado, 1, 29)) ||
                        (!esBisiesto && ValidarNumeroIngresado(out diaFinal, diaIgresado, 1, 28)))
                        ||
                        ((MesFinal == 1 || MesFinal == 3 || MesFinal == 5 || MesFinal == 7 || MesFinal == 8 || MesFinal == 10 || MesFinal == 12) && ValidarNumeroIngresado(out diaFinal, diaIgresado, 1, 31))
                        ||
                        ((MesFinal == 4 || MesFinal == 6 || MesFinal == 9 || MesFinal == 11) && ValidarNumeroIngresado(out diaFinal, diaIgresado, 1, 30))
                )
                {
                    fechaFinal = new DateTime(anioFinal, MesFinal, diaFinal);
                    return true;
                }
            }
            fechaFinal = DateTime.MinValue;
            return false;
        }

        public static bool VerificarEsAnioBisiesto(ushort anioIngresado)
        {
            if (anioIngresado != 0 && (anioIngresado % 400 == 0 || (anioIngresado % 4 == 0 && anioIngresado % 100 != 0)))
            {
                return true;
            }
            return false;
        }

        public static TimeSpan CalcularAniosDiferencia(DateTime fechaNacimiento)
        {
            return DateTime.Now - fechaNacimiento;
        }

        public static byte CalcularAniosTotales(DateTime fechaNacimiento)
        {
            TimeSpan edadActual = CalcularAniosDiferencia(fechaNacimiento);
            double aniosConvertidos = (double)edadActual.TotalDays / 365.2425;
            return (byte)aniosConvertidos;
        }

        public static bool ValidarFechaNacimiento(out DateTime fechaFinal, out byte edadActual, string anioIngresado, string mesIngresado, string diaIgresado)
        {
            if (ValidarFechaIngresada(out fechaFinal, anioIngresado, mesIngresado, diaIgresado))
            {
                edadActual = CalcularAniosTotales(fechaFinal);
                if (edadActual >= 18)
                {
                    return true;
                }
                return false;
            }
            fechaFinal = DateTime.UtcNow;
            edadActual = 0;
            return false;
        }


        public static decimal CalcularDescuento(decimal precio, decimal descuento)
        {
            return precio - (precio * descuento / 100);
        }

        public static decimal CalcularDescuento(decimal precio, decimal descuento, out decimal descuentoAplicado)
        {
            descuentoAplicado = (precio * descuento / 100);
            return precio - descuentoAplicado;
        }

        public static decimal CalcularInteres(decimal precio, decimal interes)
        {
            return precio + (precio * interes / 100);
        }

        public static decimal CalcularInteres(decimal precio, decimal interes, out decimal interesAplicado)
        {
            interesAplicado = (precio * interes / 100);
            return precio + interesAplicado;
        }
    }
}
