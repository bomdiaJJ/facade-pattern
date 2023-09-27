internal class Program {

    private static void Main(string[] args) {
        Console.WriteLine("Selecione seu compo"); 
        Console.WriteLine("1. Combo Bom"); 
        Console.WriteLine("2. Combo ruim"); 
        Console.Write("Sua escolha: ");

        int escolha = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("---------------\n");

        Combo combo = new();
        combo.CriarCombo(escolha);

        Console.WriteLine(combo);
    }

}

public class Produto {
    public string Descricao { get; set; } = "";
    public double Preco { get; set;} = 0.0;
}

public class Burger : Produto {
    public int Gramas { get; set; } = 0;
}

public class Sobremesa : Produto {
    public string Tamanho { get; set; } = "";
}

public class Bebida : Produto {
    public int Ml { get; set; } = 0;
}

public class Combo {
    private Burger _burger = new();
    private Sobremesa _sobremesa = new();
    private Bebida _bebida = new();

    public override string ToString() {
        return string.Concat(
            "Burger: ", _burger.Descricao, " - peso: ", _burger.Gramas, " - por: ", _burger.Preco, "\n",
            "Bebida: ", _bebida.Descricao, " - mls: ", _bebida.Ml, " - por: ", _bebida.Preco, "\n",
            "Sobremesa: ", _sobremesa.Descricao, " - tamanho: ", _sobremesa.Tamanho, " - por: ", _sobremesa.Preco, "\n"
        );
    }

    public void CriarCombo(int comboId) {
        switch (comboId) {
            case 1:
                _burger = new Burger {
                    Descricao = "X Bacon",
                    Preco = 3.33,
                    Gramas = 300
                };
                _sobremesa = new Sobremesa {
                    Descricao = "Bolo floresta negra",
                    Preco = 1.55,
                    Tamanho = "Grande (inteiro)"
                };
                _bebida = new Bebida {
                    Descricao = "Litrão de Smirnoff Ice",
                    Preco = 0.50,
                    Ml = 1001
                };
                break;
            case 2:
                _burger = new Burger {
                    Descricao = "X Salada",
                    Preco = 50,
                    Gramas = 10
                };
                _sobremesa = new Sobremesa {
                    Descricao = "Goiabada",
                    Preco = 125.50,
                    Tamanho = "BEM pequena"
                };
                _bebida = new Bebida {
                    Descricao = "Água",
                    Preco = 1000.00,
                    Ml = 3
                };
                break;
        }
    }
}