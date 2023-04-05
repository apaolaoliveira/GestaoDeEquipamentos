namespace GestaoDeEquipamentos
{
    using System;
    using System.Collections;

    internal class Program
    {
        #region Variáveis e ArrayLists
        static int idEquipamento = 1;
        static int idChamado = 1;

        static ArrayList arrayIdEquipamento = new ArrayList();
        static ArrayList arrayIdChamado = new ArrayList();

        //Controle de equipamentos
        static int contadorEquipamentos = 0;

        static ArrayList nomes = new ArrayList();
        static ArrayList precos = new ArrayList();
        static ArrayList numeroSerie = new ArrayList();
        static ArrayList datas = new ArrayList();
        static ArrayList fabricantes = new ArrayList();

        //Controle de chamados
        static int contadorChamados = 0;

        static ArrayList titulos = new ArrayList();
        static ArrayList descricoes = new ArrayList();
        static ArrayList equipamentos = new ArrayList();
        static ArrayList aberturas = new ArrayList();

        //Menus
        static int opcaoMenuPrincipal = 0, opcaoMenuEquipamentos = 0, opcaoMenuChamados = 0;
        #endregion

        #region Inventário Predefinido
        static void InventarioPredefinido()
        {
            //Equipamento
            arrayIdEquipamento.Add(idEquipamento++);
            nomes.Add("Notebook Dell Inspiron 15");
            precos.Add("R$ 5.499,00");
            numeroSerie.Add("565465-DELL-INSP-15");
            datas.Add("20/06/2022");
            fabricantes.Add("Dell");

            arrayIdEquipamento.Add(idEquipamento++);
            nomes.Add("Monitor LG UltraGear 27\"");
            precos.Add("R$ 2.999,00");
            numeroSerie.Add("65778-LG-ULTRAGEAR-27");
            datas.Add("10/04/2022");
            fabricantes.Add("LG");

            arrayIdEquipamento.Add(idEquipamento++);
            nomes.Add("Teclado Mecânico HyperX");
            precos.Add("R$ 579,00");
            numeroSerie.Add("787798-HYPERX-ALLOY-FPS");
            datas.Add("05/07/2021");
            fabricantes.Add("HyperX");

            arrayIdEquipamento.Add(idEquipamento++);
            nomes.Add("Mouse s/ fio Logitech Master 3");
            precos.Add("R$ 799,00");
            numeroSerie.Add("46465-LOGITECH-MX-MASTER-3");
            datas.Add("28/02/2022");
            fabricantes.Add("Logitech");

            idEquipamento = 4;
            contadorEquipamentos = 4;

            /*Média caracteres: 30, 14, 22, 14, 10*/

            //----------------------------------

            //Chamado
            arrayIdChamado.Add(idChamado++);
            titulos.Add("Gato Hacker");
            descricoes.Add("\"Meu gato subio na minha mesa, digitou códigos secretos e agora o teclado não funciona mais.\"");
            equipamentos.Add("Teclado Mecânico HyperX FPS Pro");
            aberturas.Add("01/04/2023");

            arrayIdChamado.Add(idChamado++);
            titulos.Add("A ventoinha de avião");
            descricoes.Add("\"Resolvi abrir duas abas do Visual Studio, meu notebook começou a se preparar para a decolagem.\"");
            equipamentos.Add("Notebook Dell XPS 13");
            aberturas.Add("03/04/2023");

            arrayIdChamado.Add(idChamado++);
            titulos.Add("Chuva de granizo");
            descricoes.Add("\"Após uma tempestade de granizo, um pedaço grande acabou atingindo a tela da TV. Agora só vejo chuvisco na imagem!\"");
            equipamentos.Add("Smart TV Samsung");
            aberturas.Add("02/04/2023");

            arrayIdChamado.Add(idChamado++);
            titulos.Add("Criança endiabrada");
            descricoes.Add("\"Minha irmãzinha chutou uma bola na TV da sala, agora ta uma mancha preta na tela. Não pode jogar bola dentro de casa!\"");
            equipamentos.Add("Televisão LG 42\"");
            aberturas.Add("31/03/2023");

            contadorChamados = 4;
            idChamado = 4;

            /*Média caracteres: 20, 150, 30, 10*/
        }
        #endregion

        #region Exibir mensagem colorida 
        static void MensagemColorida(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }
        #endregion

        #region Menu Principal e Main
        static int MenuPrincipal()
        {
            Console.Clear();

            MensagemColorida(" GESTÃO DE EQUIPAMENTOS E CHAMADOS ", ConsoleColor.DarkYellow);
            MensagemColorida("\n\n       MENU PRINCIPAL", ConsoleColor.DarkYellow);
            MensagemColorida("----------------------------", ConsoleColor.DarkYellow);
            Console.WriteLine("[1] Gerenciar Equipamentos.");
            Console.WriteLine("[2] Gerenciar Chamados.");
            Console.WriteLine("[3] Sair.");
            opcaoMenuPrincipal = Convert.ToInt32(Console.ReadLine());

            return opcaoMenuPrincipal;
        }

        static void Main(string[] args)
        {
            InventarioPredefinido();

            bool continuar = true;

            while (continuar)
            {
                opcaoMenuPrincipal = MenuPrincipal();

                switch (opcaoMenuPrincipal)
                {
                    case 1:
                        while (opcaoMenuEquipamentos != 5)
                        {
                            Console.Clear();

                            MensagemColorida("\n            MENU EQUIPAMENTOS", ConsoleColor.DarkYellow);
                            MensagemColorida("-----------------------------------------", ConsoleColor.DarkYellow);
                            Console.WriteLine("[1] Visualizar equipamentos registrados.");
                            Console.WriteLine("[2] Registrar novo equipamento.");
                            Console.WriteLine("[3] Editar equipamento.");
                            Console.WriteLine("[4] Excluir equipamento.");
                            Console.WriteLine("[5] Voltar ao menu principal.");
                            opcaoMenuEquipamentos = Convert.ToInt32(Console.ReadLine());

                            switch (opcaoMenuEquipamentos)
                            {
                                case 1: VisualizarEquipamentos(); break;
                                case 2: RegistrarEquipamento();   break;
                                case 3: EditarEquipamento();      break;
                                case 4: ExcluirEquipamento();     break;
                                case 5: break;
                            }
                        }
                        opcaoMenuEquipamentos = 0;
                        break;

                    case 2:
                        while (opcaoMenuChamados != 5)
                        {
                            Console.Clear();

                            MensagemColorida("\n           MENU CHAMADOS", ConsoleColor.DarkYellow);
                            MensagemColorida("--------------------------------------", ConsoleColor.DarkYellow);
                            Console.WriteLine("[1] Visualizar chamados registrados.");
                            Console.WriteLine("[2] Catalogar novo chamado.");
                            Console.WriteLine("[3] Editar chamado.");
                            Console.WriteLine("[4] Excluir chamado.");
                            Console.WriteLine("[5] Voltar ao menu principal.");
                            opcaoMenuChamados = Convert.ToInt32(Console.ReadLine());

                            switch (opcaoMenuChamados)
                            {
                                case 1: VisualizarChamados(); break;
                                case 2: RegistrarChamado();   break;
                                case 3: EditarChamado();      break;
                                case 4: ExcluirChamado();     break;
                                case 5: break;
                            }
                        }
                        opcaoMenuChamados = 0;
                        break;

                    case 3: 
                        continuar = false; 
                        break;
                }
            }
            Console.Clear();
            MensagemColorida("\nPrograma encerrado. Pressione qualquer tecla para sair.", ConsoleColor.Red);
            Console.ReadKey();
        }
        #endregion 

        #region Equipamentos
        static void VisualizarEquipamentos()
        {   
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n                                             EQUIPAMENTOS REGISTRADOS                                               ");
            Console.WriteLine("\n -------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("| ID | NÚMERO DE SÉRIE              | NOME                         | PREÇO        | DATA DE FABRICAÇÃO | FABRICANTE |");
            Console.WriteLine(" -------------------------------------------------------------------------------------------------------------------");
            Console.ResetColor();

            if (contadorEquipamentos == 0)
            {
                MensagemColorida("Nenhum equipamento registrado.", ConsoleColor.DarkRed);
                Console.ReadLine();
                return;
            }

            for (int i = 0; i < arrayIdEquipamento.Count; i++)
            {
                Console.WriteLine("|{0,-4}|{1,-30}|{2,-30}|{3,-14}|{4,-20}|{5,-12}|", arrayIdEquipamento[i], numeroSerie[i], nomes[i], precos[i], datas[i], fabricantes[i]);
            }

            MensagemColorida(" -------------------------------------------------------------------------------------------------------------------", ConsoleColor.Cyan);
            Console.ReadLine();
        }

        static void RegistrarEquipamento()
        {
            MensagemColorida("\n            NOVO REGISTRO", ConsoleColor.Cyan);

            Console.Write("\nNome: ");
            string nome = Console.ReadLine();

            while (nome.Length < 6)
            {
                MensagemColorida("\nMínimo de 6 caracteres exigido.", ConsoleColor.Red);
                Console.Write("\nNome: ");
                nome = Console.ReadLine();
            }

            Console.Write("\nPreço: ");
            string preco = Console.ReadLine();

            Console.Write("\nNúmero de série: ");
            string identificacao = Console.ReadLine();

            Console.Write("\nData de fabricação: ");
            string data = Console.ReadLine();

            Console.Write("\nFabricante: ");
            string fabricante = Console.ReadLine();

            idEquipamento++;
            arrayIdEquipamento.Add(idEquipamento);
            nomes.Add(nome);
            precos.Add(preco);
            numeroSerie.Add(identificacao);
            datas.Add(data);
            fabricantes.Add(fabricante);

            contadorEquipamentos++;

            MensagemColorida("\nEquipamento Registrado!", ConsoleColor.Green);
            Console.ReadLine();
        }

        static void EditarEquipamento()
        {
            MensagemColorida("\n            EDITAR EQUIPAMENTO", ConsoleColor.Cyan);

            Console.Write("\nInforme o ID do equipamento que deseja editar: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine()) - 1;

            if (idSelecionado < 0 || idSelecionado >= arrayIdEquipamento.Count)
            {
                MensagemColorida("Identificação inválida. Tente novamente: ", ConsoleColor.Red);
                idSelecionado = Convert.ToInt32(Console.ReadLine()) - 1;
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nO que gostaria de mudar?");
            Console.WriteLine("\n[1] Nome.");
            Console.WriteLine("[2] Preço.");
            Console.WriteLine("[3] Numero de série.");
            Console.WriteLine("[4] Data de fabricação.");
            Console.WriteLine("[5] Fabricante.");
            Console.ResetColor();
            int opcaoMenuEditar = Convert.ToInt32(Console.ReadLine());

            string novoNome, novoPreco, novoNumeroSerie, novaData, novoFabricante;

            switch (opcaoMenuEditar)
            {
                case 1:
                    Console.Write("\nNovo nome: ");
                    novoNome = Console.ReadLine();
                    nomes[idSelecionado] = novoNome;
                    break;
                case 2:
                    Console.Write("\nNovo preço: ");
                    novoPreco = Console.ReadLine();
                    precos[idSelecionado] = novoPreco;
                    break;
                case 3:
                    Console.Write("\nNovo número de série: ");
                    novoNumeroSerie = Console.ReadLine();
                    numeroSerie[idSelecionado] = novoNumeroSerie;
                    break; ;
                case 4:
                    Console.Write("\nNova data de fabricação: ");
                    novaData = Console.ReadLine();
                    datas[idSelecionado] = novaData;
                    break;
                case 5:
                    Console.Write("\nNovo fabricante: ");
                    novoFabricante = Console.ReadLine();
                    fabricantes[idSelecionado] = novoFabricante;
                    break;
            }

            MensagemColorida("\nEquipamento editado com sucesso!", ConsoleColor.Green);
            Console.ReadLine();
        }

        static void ExcluirEquipamento()
        {
            MensagemColorida("\n            EXCLUIR EQUIPAMENTO", ConsoleColor.Cyan);

            Console.Write("\nDigite o ID do equipamento que deseja excluir: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            while (idSelecionado > arrayIdEquipamento.Count || idSelecionado == 0)
            {
                MensagemColorida("Esse equipamento não existe. Tente novamente: ", ConsoleColor.DarkRed);
                idSelecionado = Convert.ToInt32(Console.ReadLine());
            }

            int posicao = arrayIdEquipamento.IndexOf(idSelecionado);

            arrayIdEquipamento.RemoveAt(posicao);
            nomes.RemoveAt(posicao);
            precos.RemoveAt(posicao);
            numeroSerie.RemoveAt(posicao);
            datas.RemoveAt(posicao);
            fabricantes.RemoveAt(posicao);

            MensagemColorida("\nEquipamento excluido com sucesso!", ConsoleColor.Green);
            Console.ReadLine();
        }
        #endregion

        #region Chamados
        static void VisualizarChamados()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n                                  CHAMADOS REGISTRADOS");
            Console.WriteLine("\n --------------------------------------------------------------------------------");
            Console.WriteLine("| ID | TÍTULO             | EQUIPAMENTO                       | DATA DE ABERTURA |");
            Console.WriteLine(" --------------------------------------------------------------------------------");
            Console.ResetColor();

            if (contadorChamados == 0)
            {
                MensagemColorida("Nenhum chamado registrado.", ConsoleColor.DarkRed);
                Console.ReadLine();
                return;
            }

            for (int i = 0; i < arrayIdChamado.Count; i++) 
            {
                Console.WriteLine("|{0,-4}|{1,-20}|{2,-35}|{3,-18}|", arrayIdChamado[i], titulos[i], equipamentos[i], aberturas[i]);
            }

            MensagemColorida(" --------------------------------------------------------------------------------", ConsoleColor.Blue);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n -----------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("| ID | DESCRIÇÃO                                                                                                              |");
            Console.WriteLine(" -----------------------------------------------------------------------------------------------------------------------------");
            Console.ResetColor();

            for (int i = 0; i < arrayIdChamado.Count; i++)
            {
                Console.WriteLine("|{0,-4}|{1,-120}|", arrayIdChamado[i], descricoes[i]);
            }

            MensagemColorida(" -----------------------------------------------------------------------------------------------------------------------------", ConsoleColor.Blue);


            Console.ReadLine();
        }

        static void RegistrarChamado()
        {
            MensagemColorida("\n            NOVO CHAMADO", ConsoleColor.Blue);

            Console.Write("\nTítulo: ");
            string titulo = Console.ReadLine();

            Console.Write("\nDescrição: ");
            string descricao = Console.ReadLine();

            Console.Write("\nEquipamento: ");
            string equipamento = Console.ReadLine();

            Console.Write("\nData de abertura: ");
            string data = Console.ReadLine();

            idChamado++;
            arrayIdChamado.Add(idChamado);
            titulos.Add(titulo);
            descricoes.Add(descricao);
            equipamentos.Add(equipamento);
            aberturas.Add(data);

            contadorChamados++;

            MensagemColorida("\nChamado Registrado!", ConsoleColor.Green);
            Console.ReadLine();
        }

        static void EditarChamado()
        {
            MensagemColorida("\n            EDITAR CHAMADO", ConsoleColor.Blue);

            Console.Write("\nInforme o ID do chamado que deseja editar: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine()) - 1;

            if (idSelecionado < 0 || idSelecionado >= arrayIdChamado.Count)
            {
                MensagemColorida("Identificação inválida. Tente novamente: ", ConsoleColor.Red);
                idSelecionado = Convert.ToInt32(Console.ReadLine()) - 1;
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nO que gostaria de mudar?");
            Console.WriteLine("\n[1] Título.");
            Console.WriteLine("[2] Descrição.");
            Console.WriteLine("[3] Equipamento.");
            Console.WriteLine("[4] Data de abertura.");
            Console.ResetColor();
            int opcaoMenuEditar = Convert.ToInt32(Console.ReadLine());

            string novoTitulo, novaDescricao, novoEquipamento, novaAbertura;

            switch (opcaoMenuEditar)
            {
                case 1:
                    Console.Write("\nNovo título: ");
                    novoTitulo = Console.ReadLine();
                    titulos[idSelecionado] = novoTitulo;
                    break;
                case 2:
                    Console.Write("\nNova descrição: ");
                    novaDescricao = Console.ReadLine();
                    descricoes[idSelecionado] = novaDescricao;
                    break;
                case 3:
                    Console.Write("\nNovo equipamento: ");
                    novoEquipamento = Console.ReadLine();
                    equipamentos[idSelecionado] = novoEquipamento;
                    break; ;
                case 4:
                    Console.Write("\nNova data de abertura: ");
                    novaAbertura = Console.ReadLine();
                    aberturas[idSelecionado] = novaAbertura;
                    break;
            }

            MensagemColorida("\nChamado editado com sucesso!", ConsoleColor.Green);
            Console.ReadLine();
        }

        static void ExcluirChamado()
        {
            MensagemColorida("\n            EXCLUIR CHAMADO", ConsoleColor.Blue);

            Console.Write("\nDigite o ID do chamado que deseja excluir: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            while (idSelecionado > arrayIdChamado.Count || idSelecionado == 0)
            {
                MensagemColorida("Esse chamado não existe. Tente novamente: ", ConsoleColor.DarkRed);
                idSelecionado = Convert.ToInt32(Console.ReadLine());
            }

            int posicao = arrayIdChamado.IndexOf(idSelecionado);

            arrayIdChamado.RemoveAt(posicao);
            titulos.RemoveAt(posicao);
            descricoes.RemoveAt(posicao);
            equipamentos.RemoveAt(posicao);
            aberturas.RemoveAt(posicao);

            MensagemColorida("\nChamado excluido com sucesso!", ConsoleColor.Green);
            Console.ReadLine();
        }
        #endregion

    }
}