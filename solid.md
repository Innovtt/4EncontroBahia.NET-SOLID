#S.O.L.I.D.
##O que é isso?

#
#
#
#

##### *João Bosco Seixas - INNOVT*

---
#S.O.L.I.D.
#### S => Single Responsibility Principle (SRP)
#### O => Open Closed Principle (OCP)
#### L => Liskov Substitution Principle (LSP)
#### I => Interface Segragation Principle (ISP)
#### D => Dependency Inversion Principle (DIP)
---

##Porque é importante?

O principal objetivo de seguir esses principios, é facilitar a construção e manutenção do sistema.

#####Seja um programador profissional

> Lembre-se:  
> Seu objetivo como programador é produzir código 
    que outros humanos consigam entender.
 


---

##Principio da Responsabilidade Única (SRP)
1. Talvez o princípio mais importante na orientação a objetos, tudo bem a partir dele
2. Todo módulo, método ou classe, deve ter responsabilidade sobre somente uma coisa.
3. Evite fazer classes Canivete Suiço/Rambo
4. Quando se tem apenas 1 responsabilidade, fica fácil identificar onde o erro está ocorrendo.
> “NUNCA DEVE EXISTIR MAIS DE UM MOTIVO PARA MODIFICAR UMA CLASSE”  
> -Uncle Bob 

---

###Open Closed Principle (OCP)

1. Aberto para extensão
2. Fechado para modificação
3. O objetivo é tornar possível a expansão da classe, sem quebrar os comportamentos que já existem

---

###Substituição de Liskov (LSP)
1. O uso de uma classe derivada no lugar de uma classe base, não deve gerar comportamento estranho.
2. Os utilizadores das classes não sabem se vão receber a classe base ou derivada, portanto os comportamentos devem ser íntegros.

---

###Interface Segragation (ISP)
1. Diz respeito a dividir os contratos de interfaces de acordo com suas responsabilidades
2. Linguagens OO podem aplicar vários contratos(interfaces) em um único objeto. 
3. Tire vantagem disso para fazer a comunicação fluir melhor.
4. Muitas interfaces específicas são melhores do que uma interface única.
5. Clientes não devem ser forçados a depender de métodos que não usam

---

###Inversão de Dependência (DIP)

Suprir a classe dependente através de Construtor ou Método

> Boa prática: Se uma classe possui uma dependência externa importante, obrigue a passagem do parâmetro no construtor.

--

##BÔNUS!!!
#Tell dont Ask

1. Não se deve perguntar a um objeto sobre seu estado para depois efetuar a operação. 
2. Ao solicitar a operação o objeto tem que saber executá-la de acordo com o estado.

