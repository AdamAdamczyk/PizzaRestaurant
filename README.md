## Uruchomienie
- SQL Server management - Przed uruchomieniem należy podmienić DefaultConnection w pliku appsettings.json oraz wykonać migrację dla serwisów 
Restaurant.Services.ShoppingCartAPI oraz Restaurant.Services.ProductAPI

## Opis Aplikacji:
Aplikacja pozwala na prowadzanie restauracji przez internet, poprzez prezentację oferty. Aplikacja pozwala również na internetową sprzedaż produktów, które
są dostępne w ofercie. System logowania stworzony został tak, aby tylko administrator strony mógł usuwać oraz dodawać produkty, 
użytkownik może jedynie wykonać zamówienie. 

## Mikroserwisy
- Restaurant.Web - Aplikacja kliencka posiadająca UI
- Restaurant.Services.indetity - System logowania
- Restaurant.Services.ProductAPI - REST API odpowiedzialny za obslugę produktów
- Restaurant.Services.ShoppingCartAPI - REST API odpowiedzialny za obslugę koszyka
