# communopoly
Gra inspirowana Monopoly lub Eurobusiness z motywem komunistycznym

# Zasady

Gracz rozpoczyna ze stałą liczbą punktów, a wygrywa osoba która jako ostatnia wszystkie je straci.
Przy każdym okrążeniu pola startu gracze otrzymują x punktów

* Gracz rozpoczyna ze stałą liczbą punktów, a wygrywa osoba która jako ostatnia wszystkie je straci.

* Przy każdym okrążeniu pola startu gracze otrzymują x punktów.

* Oto o ile pól poruszy się gracz zadecyduje rzut kostką.

![Prototyp planszy](./svg/plansza.svg)

# Pola
* ![Niebieskie pola](./svg/niebieskie_pole.svg) **"Syberia"**:

Gracze na tych polach będą mieli utrudnioną możliwośc poruszania się.
Aby przesunąć się o jedno polę trzeba wylosować dwa, o dwa pola cztery itd.


* ![Czarne pole](./svg/czarne_pole.svg) **"Zsyłka na Syberię"**:

Będzie to obszar który będzie się pojawiać na każdej mapie.
Gdy wejdziemy na to pole zostaniemy automatycznie przeniesieni na Syberię, czas przeniesienia to 3 tury.
Gracz może uniknąć przeniesienia pod warunkiem, że wylosował szóstkę bądź posiada Kartę partii Pracy.


* ![Czerwone pole](./svg/czerwone_pole.svg) **"Redystrybucja majątku"**:

Jeśli któryś z graczy wejdzię na to pole to automatycznie gracz z największą ilością punktów przekazuje *pewną ilość* swoich punktów osobię z najmniejszą ilością punktów.


* ![Seledynowe pole](./svg/seledynowe_pole.svg) **"Przymuszona reedukacja"**:

 Gracz może opuścić to polę za zapłatą *pewnej ilości* swoich punktów bądź zostać tam na 3 tury podczas których będą wpajane mu idee komunizmu.


* ![Fioletowe pole](./svg/fioletowe_pole.svg) **"Losowe wydarzenie"**:

Gracz losuje kartę z puli kart. Wylosowana karta może mieć pozytywny efekt np. otrzymanie jakieś ilości kartek, lub negatywny efekt np. przeniesienie pionka gracza na Syberię lub inne nie specjalne pole.
Pola losowego wydarzenia są na stałe przypisane do *Ukrainy* i *Uzbekistanu*.


* ![Białe pola](./svg/biale_pole.svg) **"Stacja kolejowa"**:

Umożliwia przemieszczenie się pionka gracza do innych pól stacji:
Gracz może wybrać czy chce zapłacić *pewną ilość* kartek za przejazd, może wtedy wybrać na którą inną stację chce się przenieść.
Może też wybrać jazdę na gapę/bez opłaty, ale nie może wtedy wybrać stacji docelowej i pionek będzie przenoszony na losową stację (oprócz stacji na której stoi pionek)


* ![Bordowe pole](./svg/bordowe_pole.svg) **Bordowe pola z krajami**:

Bordowe pola są losowo wybranymi krajami należącymi do ZSRR. Każdy z nich będzie posiadać swoje unikalne wydarzenia. Poruszanie się w nich będzie skutkować zyskiem lub straty waluty.
