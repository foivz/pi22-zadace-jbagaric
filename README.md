
# Specifikacija softverskih zahtjeva za Signal Localization v1.0

## Podaci o studentu

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Josipa Bagarić | jbagaric20@foi.hr | 0016147941 | jbagaric


## Opis domene
U štićenim objektima poput zatvora i kaznionica javlja se problem nedozvoljenog korištenja mobilnih uređaja koji su zabranjeni zbog nedozvoljenih komunikacija i mogućih kriminalnih aktivnosti. U ovom projektu opisana je specifikacija softverskih zahtjeva za softversko rješenje Signal Localization v1.0 za koji se smatra da će riješiti problem nedozvoljenih uređaja u štićenim objektima.

## Specifikacija projekta
Zahtjevi za funkcionalnošću ovog programskog proizvoda su trenutno lociranje dozvoljenih i nedozvoljenih uređaja, uvid u povijest uređaja koji su se pojavljivali i njohvo simulirano kretanje, ograničenje pristupa podacima, obavještavanje o pojavi novog uređaja mailom ili sms porukom, mogućnost dizajniranja štićenog objekta te njegov opis

## Zadatak
link zadatka na moodlu: https://elf.foi.hr/mod/resource/view.php?id=88396

## Izvještaj
Implementacija funkcionalnosti ne slijedi u velikoj mjeri prethodno napravljene dijagrame. To ne mora značiti da su krivi nego možda previše komplicirani meni da bi implementirala sve kao na njima. Sa dijagrama klasa implementirane su klase: Osoba, Zatvorenik, Prostorija, ProstorijaRepository i ZatvorenikRepository. Nije potrebno izabrati poseban kat i posebnu sobu kako bi se unijeli podaci kao što je prikazano na dijagramu aktivnosti i dijagramu slijeda. U rješenju nisam uspjela napraviti sve kako sam zamislila, ali barem CRUD radi.

