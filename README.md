# Abstração: Desafio Dio
Desafio feito em C# para demonstrar o funcionamento de abstração. Foi criada uma classe abstrata Celular e também uma Interface que aceita um tipo genérico.
As demais classes são celulares, como Apple.cs, Samsung.cs e Xiaomi.cs. Estas classes filhas implementam as propriedades da classe mãe Celular e seu método (As classes também implementam a interface ICelular). 

O método da classe abstrata gera um arquivo. assim cada classe que herde de abstract Celular vai poder gerar seu próprio tipo de arquivo
a partir da lista que é implementada pela interface ICelular com os métodos de inserção e retorno da lista.

### Abaixo o tipo de arquivo que cada Classe irá gerar.

### Apple.cs
``` csv
iPhone 6,IOS 6,2
iPhone 11,IOS 10,4
iPhone 13,IOS 11.01,5
iPhone 5,IOS 5,3
```
### Samsung.cs
``` json
[
  {
    "OS": "Android 12",
    "QtdCameras": 3,
    "Modelo": "Galaxy Flip"
  },
  {
    "OS": "Android 13",
    "QtdCameras": 4,
    "Modelo": "Galaxy Z"
  },
  {
    "OS": "Android 14",
    "QtdCameras": 6,
    "Modelo": "Galaxy Note"
  },
  {
    "OS": "Android 14",
    "QtdCameras": 5,
    "Modelo": "Galaxy S23"
  }
]
```
### Xiaomi.cs
``` xml
<?xml version="1.0" encoding="utf-8"?>
<Root>
  <Xiaomi>
    <Modelo>Mi 7</Modelo>
    <QtdCameras>4</QtdCameras>
    <OS>Android 13.02</OS>
  </Xiaomi>
  <Xiaomi>
    <Modelo>Mi 9</Modelo>
    <QtdCameras>5</QtdCameras>
    <OS>Android 13.02</OS>
  </Xiaomi>
  <Xiaomi>
    <Modelo>Mi 11</Modelo>
    <QtdCameras>6</QtdCameras>
    <OS>Android 14.02</OS>
  </Xiaomi>
  <Xiaomi>
    <Modelo>Mi 5</Modelo>
    <QtdCameras>3</QtdCameras>
    <OS>Android 12.02</OS>
  </Xiaomi>
</Root>
```

### Implementação do Método GeraArquivoListaDeItems em cada Classe.

### Apple.cs
``` c#
public static implicit operator string(Apple apple) => $"{apple.Modelo},{apple.OS},{apple.QtdCameras.ToString()}";

public override void GeraArquivoListaDeItems()
{
    File.WriteAllLines("Apple.csv", apples.Select(appl => (string)appl).ToList());
}
```

### Samsung.cs
```c#
public override void GeraArquivoListaDeItems()
{
    var option = new JsonSerializerOptions { WriteIndented = true };
    string jsonArquivo = JsonSerializer.Serialize(samsungs, option);
    File.WriteAllText("Samsung.json", jsonArquivo);
}
```

### Xiaomi.cs
```c#
public override void GeraArquivoListaDeItems()
{
    XmlSerializer serializer = new XmlSerializer(typeof(XElement));

    XElement xiaomi = new XElement("Root");
    foreach (Xiaomi item in mis)
    {
          xiaomi.Add(new XElement("Xiaomi", 
                       new XElement("Modelo", item.Modelo),
                       new XElement("QtdCameras", item.QtdCameras),
                       new XElement("OS", item.OS)
          ));
    }

    TextWriter writer = new StreamWriter("Xiaomi.xml");
    var xmlWriter = XmlWriter.Create(writer, new XmlWriterSettings { Indent = true });
    serializer.Serialize(xmlWriter, xiaomi);        
}
```
