using System;

namespace JuegoComplejos
{
    class Program
    {
        static void Main(string[] args)

        {
            //Declaracion de Varibales
            int ComplejosTotales = 0;
            string RespuestaFinal;
            int Desicion;
            int AdministracionNorte = 0;
            int AdministracionSur = 0;
            int OficinaAdminEste = 0;
            int Bano = 0;
            int Subterraneo = 0;
            int OficinaPrincipal = 0;
            int Respuesta1;
            int Respuesta2;
            int Respuesta3;
            int Respuesta4;
            int Respuesta5;
            string Respuesta6;
            int Respuesta7;



            //Inicio del juego
            Console.WriteLine("Estas en una realidad distopica. Tu nombre es Becca, una espía.");
            Console.WriteLine("Tienes una misión de rescate, así que debes actuar con prudencia.");
            Console.WriteLine("Cuentas con una herramienta de hackeo que solo puede usarse una vez, estas prohibida de llevar armas. ");
            Console.WriteLine("Tu objetivo es tu propio compañero encargado de buscar información de un proyecto de modificación genética, impulsada por una organización militar extranjera. ");
            Console.WriteLine("Llegas al complejo de cárceles, pero necesitas 5 llaves de los 5 administradores del complejo.");
            Console.ReadKey();
            Console.Clear();

            //Entra el while se iguala a complejos totales para poder salir del bucle

            do
            {
                Console.WriteLine("Haz realizado " + ComplejosTotales + " Pruebas");
                Console.WriteLine("¿A donde vas primero?");
                Console.WriteLine(" 1.- Oficina de Administracion Norte\n 2.-Oficina de administración sur.\n 3.-Oficina de administración este\n 4.-Baño del complejo \n 5.- Subterraneo del complejo \n 6.- Oficina principal de administracion");
                Desicion = Convert.ToInt32(Console.ReadLine());

                switch (Desicion)
                {
                    case 1:

                        //Se agrega un if igualado a 0 para cuando se supere l prueba se sume 1 y no se pueda volver a realizar
                        if (AdministracionNorte == 0)
                        {
                            Console.WriteLine("Ves que la cerradura de la puerta ha sido usada y la puerta esta entreabierta.");
                            Console.WriteLine("Oyes pasos dentro.");
                            Console.WriteLine("1 Entrar de golpe \n 2 Entrar sigilosamente ");
                            Respuesta1 = Convert.ToInt32(Console.ReadLine());
                            if (Respuesta1 == 1)
                            {
                                Console.WriteLine("entras de golpe y la persona que esta dentro se asusta y te dispara. ");
                                Console.WriteLine("Has muerto...");
                                Console.ReadKey();
                                Console.Clear();

                            }
                            else if (Respuesta1 == 2)
                            {
                                Console.WriteLine("entras sigilosamente y ves a alguien de espaldas, intentas ahorcarlo y tienes una pelea con el.");
                                Console.WriteLine("Gracias a tu fuerza logras ganarle, tiene la tarjeta que necesitas en la mano, se la quitas y vuelves a registrar la llave.");
                                //Suma en el caso Admistracion Norte + 1 para no volver a realizar la prueba
                                AdministracionNorte = AdministracionNorte + 1;
                                //Suma en los complejos listos a +1 para imprimir el marcador 
                                ComplejosTotales = ComplejosTotales + 1;
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }

                        else if (AdministracionNorte != 0)
                        {
                            Console.WriteLine("Ya realizaste este complejo...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 2:

                        if (AdministracionSur == 0)
                        {
                            Console.WriteLine("La cerradura de esta puerta es anti-hackeo, por lo que tu herramienta no funcionara. ");
                            Console.WriteLine("La cerradura esta mal ensamblada y una de sus partes es bastante endeble y va directamente a su placa base. ");
                            Console.WriteLine("1 Decides usar tu fuerza para golpear la cerradura y romper la cerradura. \n 2 Decides abrirla despacio e intentar desactivarla manualmente.");
                            Respuesta2 = Convert.ToInt32(Console.ReadLine());
                            if (Respuesta2 == 1)
                            {
                                Console.WriteLine("La fuerza bruta ha ganado esta pelea, la puerta se abre. ");
                                Console.WriteLine("Entras a la oficina, el administrador esta muerto, le robas su tarjeta y vuelves a registrar la llave.");
                                Console.WriteLine("Lo haz logrado");
                                Console.ReadKey();
                                Console.Clear();
                                AdministracionSur = AdministracionSur + 1;
                                ComplejosTotales = ComplejosTotales + 1;

                            }
                            else if (Respuesta2 == 2)
                            {
                                Console.WriteLine("Manipular la cerradura cuidadosamete a activado las torretas que cuidan la oficina, has muerto. ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }

                        else if (AdministracionSur != 0)
                        {
                            Console.WriteLine("Ya realizaste este complejo...");
                            Console.ReadKey();
                            Console.Clear();
                        }

                        break;

                    case 3:
                        if (OficinaAdminEste == 0)
                        {
                            Console.WriteLine("Esta Oficina esta abierta, pero celosamente cuidada por alguien que viste completamente de negro y carga un arma, no parece muy fuerte. ");
                            Console.WriteLine("1 Esperas hasta que se mueva.\n 2 Te enfrentas a el cara a cara.");
                            Respuesta3 = Convert.ToInt32(Console.ReadLine());

                            if (Respuesta3 == 1)
                            {
                                Console.WriteLine("El guardia se ha cansado y se ha quedado dormido apoyado en la pared. Te acercas y lo noqueas. Entras en la habitación, el administrador esta muerto, pero no encuentras su llave, salvo unos guantes de goma de limpieza, los tomas y vuelves. ");
                                Console.ReadKey();
                                Console.Clear();
                                OficinaAdminEste = OficinaAdminEste + 1;
                                ComplejosTotales = ComplejosTotales + 1;

                            }

                            else if (Respuesta3 == 2)
                            {
                                Console.WriteLine("¿Quién necesita fuerza cuando tiene un arma? Has muerto ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }

                        else if (OficinaAdminEste != 0)
                        {
                            Console.WriteLine("Ya realizaste este complejo...");
                            Console.ReadKey();
                            Console.Clear();
                        }

                        break;

                    case 4:
                        if (Bano == 0)
                        {
                            Console.WriteLine("Vas caminando por un pasillo y ves que viene alguien, te metes a una puerta y ves que es un baño, tienes que escapar al jardin y ves 2 salidas");
                            Console.WriteLine("1 Rendija de toma de aire abierta \n 2 Ventana en el baño");
                            Respuesta4 = Convert.ToInt32(Console.ReadLine());

                            if (Respuesta4 == 1)
                            {
                                Console.WriteLine("Entras a la toma de aire, solo hay un posible camino, asi que decides tomarlo, llegas al patio ");
                                Console.ReadKey();
                                Console.Clear();
                                Bano = Bano + 1;
                                ComplejosTotales = ComplejosTotales + 1;

                            }

                            else if (Respuesta4 == 2)
                            {
                                Console.WriteLine("Logras salir rapidamente al patio, pero te topas de frente a un guarda... Estas muerto");
                                Console.ReadKey();
                                Console.Clear();
                            }

                        }

                        else if (Bano == 0)
                        {
                            Console.WriteLine("Ya realizaste este complejo...");
                            Console.ReadKey();
                            Console.Clear();
                        }

                        break;

                    case 5:
                        if (Subterraneo == 0)
                        {
                            Console.WriteLine("Decides bajar al subterráneo y te encuentras con 2 caminos.");
                            Console.WriteLine("1 Al final de el camino de la izquiera hay una luz blanca muy fuerte. \n 2 En el camino de la derecha hay un pasadizo iluminado que parece no tener fin.");
                            Respuesta5 = Convert.ToInt32(Console.ReadLine());

                            if (Respuesta5 == 1)
                            {
                                Console.WriteLine("Sigues el camino y llegas a un laboratorio vacio, se ve todo nuevo y limpio, salvo los cadáveres que lo adornan, una de las llaves bri. lla en el bolsillo de uno de los científicos, la tomas y la llevas a registrarla ");
                                Console.ReadKey();
                                Console.Clear();
                                Subterraneo = Subterraneo + 1;
                                ComplejosTotales = ComplejosTotales + 1;

                            }

                            else if (Respuesta5 == 2)
                            {
                                Console.WriteLine("Vas por el pasadizo, y accidentalmente pisas una trampa de cuerda, explota y mueres. ");
                                Console.ReadKey();
                                Console.Clear();
                            }

                        }

                        else if (Subterraneo != 0)
                        {
                            Console.WriteLine("Ya realizaste este complejo...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 6:
                        if (OficinaPrincipal == 0)
                        {
                            Console.WriteLine("Esta cerradura es perfectamente hackeable, pero tiene un sistema de defensa eléctrica, inutilizara tu herramienta de hackeo y te matara si no tienes con que protegerte de la ELECTRICIDAD.");
                            Console.WriteLine("Deseas continuar si / no? ");
                            Respuesta6 = Console.ReadLine().ToUpper();
                            if (Respuesta6 == "SI")
                            {
                                Console.WriteLine("Como abriras la cerradura?");
                                Console.WriteLine("1 Usas tus herraminetas sin ninguna proteccion \n 2 Te colocas primero unos guantes");
                                Respuesta7 = Convert.ToInt32(Console.ReadLine());

                                if (Respuesta7 == 1)
                                {
                                    Console.WriteLine("usas tu herramienta sin ninguna proteccion, el broche de seguridad ha saltado, has muerto ");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else if (Respuesta7 == 2)
                                {
                                    Console.WriteLine("lograste abrir la puerta y ves al administrador sentado en su silla, moribundo.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    OficinaPrincipal = OficinaPrincipal + 1;
                                    ComplejosTotales = ComplejosTotales + 1;
                                }
                            }
                            else if (Respuesta6 == "NO")
                            {
                                Console.WriteLine("Ya sera otro dia...");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }

                        else if (OficinaPrincipal != 0)
                        {
                            Console.WriteLine("Ya realizaste este complejo...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                }

            } while (ComplejosTotales != 6);

            Console.WriteLine("Administrador:   “Se que vienes a liberarlo, pero no tienes ni la más mínima idea” ");
            Console.WriteLine("El administrador se cae de su silla, mientras la llave manchada con su sangre, brilla en el escritorio. ");
            Console.WriteLine("Tienes las 5 llaves, es hora de terminar con tu misión ");
            Console.WriteLine("Te dirijes a la puerta central del patio, las 5 llaves han sido puestas, y la puerta se abre lentamente, ves que no hay mas celdas aparte de la única que se ilumina en el fondo.");
            Console.WriteLine("No ves a nadie, solo escuchas el sonido del viento");
            Console.WriteLine("Los barrotes estan doblados, formando una abertura enorme");
            Console.WriteLine("Algo te agarra del cuello mientras dice tu nombre, sientes su manos grandes y heladas dejarte sin aire cada vez mas.");
            Console.WriteLine("La cosa repite: “No quiero esto Becca, ya no soy yo”");
            Console.WriteLine("La cosa te suelta, volteas y solo logras visualizar la cara deforma e hinchada a mas no poder del que en algún momento fue un espia condecorado.");
            Console.WriteLine("Escuchas sollozos entre sus palabras: “Mátame Becca, acaba con mi sufrimiento”");
            Console.WriteLine("¿Matarlo?");
            RespuestaFinal = Console.ReadLine().ToUpper();

            if (RespuestaFinal == "SI")
            {
                Console.WriteLine("Rompiste su cuello, has acabado con su sufrimiento, misión cumplida. ");

            }
            else if (RespuestaFinal == "NO")
            {
                Console.WriteLine("Te vas, mientras escuchas los lamentos incontrolables de lo que en algún momento fue un buen amigo. ");
            }


        }
    }
}