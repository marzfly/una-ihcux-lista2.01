//Exercício: Caos na Cantina
//Prof. Daniel - DDE 08/04/26

/*HEURÍSTICA 1 - VISIBILIDADE DO STATUS
O usuário pode ver em qual parte do sistema está através das barras
de progresso e da mensagem no topo da tela*/

/*HEURÍSTICA 3 - CONTROLE E LIBERDADE
O usuário pode voltar atrás para adicionar um produto ou sair do sistema*/

/*HEURÍSTICA 9 - AJUDA E ERROS
Mensagens claras apresentando o erro cometido, ao invés de algo vago*/

using System.Collections;

//Array para armazenar os pedidos
ArrayList pedido = new ArrayList();

void adicionarProduto(){
    Console.Clear();
    Console.WriteLine("[PARTE 1 DE 3]");
    Console.WriteLine("▰▱▱");
    Console.WriteLine("Digite um código de 1 a 10");
    string codigo = Console.ReadLine()!;
    int codigoInt = int.Parse(codigo);

    bool codigoValido = false;

    while (!codigoValido)
    {
        if(codigoInt < 1 || codigoInt > 10)
        {
            Console.WriteLine("Código Inválido!");
            Console.WriteLine("Os códigos dos produtos vão de 1 a 10.");
            Console.WriteLine("Por favor, tente inserir o código correto");
            codigo = Console.ReadLine()!;
            codigoInt = int.Parse(codigo);
        }
        else
        {
            codigoValido = true;
        }
    }

    pedido.Add(codigoInt);
    Console.WriteLine("Produto cadastrado com sucesso!");

    /*{
        Console.WriteLine("Código Inválido!");
        Console.WriteLine("Os códigos dos produtos vão de 1 a 10.");
        Console.WriteLine("Por favor, tente inserir o código correto");
        codigo = Console.ReadLine()!;
        codigoInt = int.Parse(codigo);
    } else {
        pedido.Add(codigoInt);
        Console.WriteLine("Produto cadastrado com sucesso!");
    }*/
}

void verProdutos(){
    Console.Clear();
    Console.WriteLine("[PARTE 2 DE 3]");
    Console.WriteLine("▰▰▱");
    Console.WriteLine("Produtos selecionados: ");
    for(int i = 0; i < pedido.Count; i++)
    {
        Console.WriteLine($"{i + 1}. Código: {pedido[i]}");
    }
    Console.WriteLine("Deseja remover algum produto?");
    Console.WriteLine("1. Sim | 2. Não");
    string escolha = Console.ReadLine();
    int escolhaInt = int.Parse(escolha);
    if(escolhaInt == 1)
    {
        Console.WriteLine("Escreva a posição do produto que você quer remover: ");
        string choice = Console.ReadLine();
        int choiceInt = int.Parse(choice);
        if(choiceInt >= 0 || choiceInt <= pedido.Count)
        {
           pedido.RemoveAt(choiceInt - 1); 
        }
        else
        {
            Console.WriteLine("Não foi possível remover o produto.");
        }
    }
}

void sair(){
    Console.WriteLine("[PARTE 3 DE 3]");
    Console.WriteLine("▰▰▰");
    Console.WriteLine("Obrigada pela preferência!");
}

////////////////////////////////////

//Opções para o usuário

Console.WriteLine("Bem-vindo ao Cantinotron 3000! Como podemos ajudar hoje?");
Console.WriteLine("1 - Cadastrar produtos");
Console.WriteLine("2 - Ver carrinho");
Console.WriteLine("3 - Sair");

//Ler opção escolhida pelo usuário
//Lê a opção em forma de string e converte para inteiro :P
string opcao = Console.ReadLine()!;
int opcaoInt = int.Parse(opcao);

while(opcaoInt != 3)
{
    if(opcaoInt == 1)
    {
        adicionarProduto();
    } else if (opcaoInt == 2) {
        verProdutos();
    }
    Console.WriteLine("1 - Cadastrar produtos");
    Console.WriteLine("2 - Visualizar carrinho");
    Console.WriteLine("3 - Sair");
    opcao = Console.ReadLine()!;
    opcaoInt = int.Parse(opcao);
}

if(opcaoInt == 3)
{
    Console.Clear();
    sair();
}