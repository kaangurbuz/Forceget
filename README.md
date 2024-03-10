# Forceget

Proje Localhost a göre geliştirildi ve cors gibi configler aşağıdaki portlara göre yapıldı
 
Angular projesi localhost:4200
Backend API localhost:7193
 
Backend tarafındaki configteki db bilgileri localhosta göre ayarlandı
 
server=127.0.0.1;database=ForcegetTestDB;User ID=root;Password=123456;

Backend kısmında migrationlarıyla beraber gönderdim, update-database ile migration atılabilir. Hazır seedler bu sırada dbye yazılacak örnek veri olsun diye. Currency, City, Country, PackageType gibi değerler için tablo oluşturdum.
