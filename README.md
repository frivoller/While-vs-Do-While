# Patika Sayacı Uygulaması

Bu uygulama, kullanıcıdan alınan bir limit değeri kadar 0'dan başlayarak bir sayaç çalıştırır ve her döngüde "Ben bir Patika'lıyım" mesajını ekrana yazdırır. Uygulama, hem `while` hem de `do-while` döngülerini kullanarak iki ayrı versiyon sunmaktadır.

## Özellikler

- Kullanıcıdan bir limit değeri girişi alır.
- 0'dan başlayarak sayaç artırır.
- Belirtilen limit değerine kadar "Ben bir Patika'lıyım" mesajını yazdırır.
- Hem `while` hem de `do-while` döngüleri ile uygulanmıştır.

## Kullanım

1. Projeyi klonlayın veya indirin.
2. C# geliştirme ortamınızı (örneğin, Visual Studio veya .NET CLI) açın.
3. Projeyi açın ve çalıştırın.
4. Konsolda istenen limit değerini girin.

## Örnek Girişler

- Pozitif bir sayı girildiğinde:
    - Giriş: `7`
    - Çıktı: 
      ```
      Ben bir Patika'lıyım
      Ben bir Patika'lıyım
      Ben bir Patika'lıyım
      Ben bir Patika'lıyım
      Ben bir Patika'lıyım
      Ben bir Patika'lıyım
      Ben bir Patika'lıyım
      ```
- Negatif bir sayı girildiğinde:
    - Giriş: `-5`
    - Çıktı: 
      ```
      Ben bir Patika'lıyım
      ```

## Farklar

- `while` döngüsü, koşul sağlanmadığı sürece döngüye girmeyecek, bu nedenle negatif limit değerleri için hiç çalışmayacaktır.
- `do-while` döngüsü ise en az bir kez çalışır, bu nedenle negatif limit değerlerinde bile "Ben bir Patika'lıyım" mesajı en az bir kez yazdırılır.

