
QUESTÃO 1:
    1. (2,5 pontos) Implemente a hierarquia Formato como descrito pelo diagrama abaixo e por este
texto:
    a. Cada FormaBidimensional deve conter um método getArea() que calcula sua área;
    b. Cada FormaTridimensional deve conter os métodos getArea() e getVolume(), para
calcular área e volume, respectivamente;
    c. Crie uma aplicação com um vetor de referência a objetos da classe Forma, cada uma
relativa a um dos objetos de cada classe concreta da hierarquia;
    d. A aplicação deve imprimir a classe de origem de cada objeto, o que deve ser
determinado em tempo de execução;
    e. A aplicação deve imprimir, para cada objeto apontado, se trata-se de uma
FormaBidimensional ou FormaTridimensional, o que deve ser determinado em tempo
de execução
    i. Se a forma for bidimensional, imprima sua área;
    ii. Se a forma for tridimensional, imprima sua área e volume.
    Forma FormaBidimensional Circulo Cubo FormaTridimensional Quadrado Triangulo Esfera Tetraedro
    Por fim, adicione um método desenhar() à classe FormaBidimensional e à hierarquia que a tem como classe
base.
    f. O construtor de cada classe concreta deverá especificar o tamanho (em quantidade de
caracteres) e o caractere de preenchimento para desenhar cada forma.


QUESTÃO 2:
    2. (2,5 pontos) Crie uma classe chamada Ingresso que possui um valor em reais e um método
imprimeValor().
    a. crie uma classe VIP, que herda Ingresso e possui um valor adicional. Crie um método
que retorne o valor do ingresso VIP (com o adicional incluído).
    b. crie uma classe Normal, que herda Ingresso e possui um método que imprime:
"Ingresso Normal".
    c. crie uma classe CamaroteInferior (que possui a localização do ingresso e métodos para
acessar e imprimir esta localização) e uma classe CamaroteSuperior, que é mais cara (possui
valor adicional). Esta última possui um método para retornar o valor do ingresso. Ambas as
classes herdam a classe VIP.
    d. crie uma classe de Teste com o método main. Neste método crie um ingresso. Peça
para o usuário digitar 1 para normal e 2 para VIP. Conforme a escolha do usuário, diga se o
ingresso é do tipo normal ou VIP. Se for VIP, peça para ele digitar 1 para camarote superior e 2
para camarote inferior. Conforme a escolha do usuário, diga se que o VIP é camarote superior
ou inferior. Imprima o valor do ingresso.
