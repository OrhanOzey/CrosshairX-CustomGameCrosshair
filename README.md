![CrosshairX Logo](https://eksiup.com/images/96/41/v5136680wue8.png)
## CrosshairX Custom Game Crosshair Maker / Open Source

Kullanmak için Setup Dosyasını Basit bir şekilde kurarak oyunlarda crosshair değişikliği yapabilirsiniz.

### Kurulum 
CrosshairX-Setup.msi Adlı setup dosyasını indirirerek kurulum gerçekleştirebilirsiniz

### Nasıl Çalışıyor ?
![CrosshairX Banner](https://eksiup.com/images/17/98/dc137305pqdo.png)
Basit mantığa dayalı bir şekilde çalışmaktadır, C# Windows Presentation Foundation (WPF) Üzerinde oluşturulmuştur,
Temelinde 2 Adet Pencere vardır, Pencerelerden birisi "Crosshair" diğeri ise "Ayarlar" Penceresidir
"Crosshair" Penceresinin arkası transparan'dır, ve ekran sıra önceliği olarak hep en önde durmaktadır. bkz:(Topmost)
"Ayarlar" Penceresi "Crosshair" Penceresi içersindeki <Image> Nesnesini kontrol eder, bu sayade "Ayarlar" Penceresindeki Kullanıcı ayarları "Crosshair" Penceresini Etkiler.
  
### Açık Kaynak
C# Windows Presentation Foundation (WPF) Üzerinde oluşturulmuştur, tamamen açık kaynaktır.
