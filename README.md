# Moving Platform in Unity2D - English

With this repository, you can learn "How to Make Moving Platform" in Unity 2D.


## Frequently asked Questions

#### What are variables for?

public float speed = 2f; - To adjust the speed of the platform.

public Transform startPoint; - To adjust the start point of the platform.

public Transform finishPoint; - To adjust the finish point of the platform.

private Vector3 targetPoint; - To determine the point where the platform should go.

#### What is meaning MoveTowards?

It is used to move an object at a certain speed in a certain direction.

ATTENTION : Don't forget to add the MovingPlatform code to your Platform.

## What you need to do in Unity

- Create an empty game object called startPoint. Then set the start point with this game object. Then drag this game object to the startPoint area in the MovingPlatform code we created earlier.

- Create an empty game object called finishPoint. Then set the finish point with this game object. Then drag this game object to the finishPoint area in the MovingPlatform code we created earlier.


## Author

- Created by Efe Baydoğan.

  ----------------------------------------------------------------------------------------------------

  # Unity2D'de Hareketli Platform - Türkçe

Bu depo ile Unity 2D'de "Hareketli Platform Nasıl Yapılır" öğrenebilirsiniz.

## Sık Sorulan Sorular

#### Değişkenler ne içindir?

public float speed = 2f; - Platformun hızını ayarlamak için.

public Transform startPoint; - Platformun başlangıç noktasını ayarlamak için.

public Transform finishPoint; - Platformun bitiş noktasını ayarlamak için.

private Vector3 targetPoint; - Platformun gitmesi gereken noktayı belirlemek için.

#### MoveTowards ne anlama geliyor?

Bir nesneyi belirli bir yönde belirli bir hızda hareket ettirmek için kullanılır.

DİKKAT : MovingPlatform kodunu Platformunuza eklemeyi unutmayın.

## Unity'de yapmanız gerekenler

- startPoint adında boş bir oyun nesnesi oluşturun. Ardından başlangıç noktasını bu oyun nesnesi ile ayarlayın. Daha sonra bu oyun nesnesini daha önce oluşturduğumuz MovingPlatform kodundaki startPoint alanına sürükleyin.

- finishPoint adında boş bir oyun nesnesi oluşturun. Ardından bitiş noktasını bu oyun nesnesi ile ayarlayın. Ardından bu oyun nesnesini daha önce oluşturduğumuz MovingPlatform kodundaki finishPoint alanına sürükleyin.

## Yazar

- Efe Baydoğan tarafından oluşturuldu.
