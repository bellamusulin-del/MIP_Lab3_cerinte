# MIP_Lab3_cerinte
Să se creeze o aplicație Windows Forms. 
Să de adauge un control de tip WebBrowser.
Să se adauge un control ToolStrip (pentru butoane).
Să se adauge butoanele (pe ToolStrip):
Navigate (Go).
Back.
Forward.
Home
Să se adauge un TextBox (pe ToolStrip) în care să se va introduce URL-ul dorit.
Pentru fiecare buton să se descarce (de pe IconArchive) și să se seteze o imagine.
Să se implementeze funcționalitățile butoanelor adăugate (Navigate, Back, etc.).
Prin dublu click pe fiecare buton se generează metoda de tratare a evenimentului de apăsare a butonului.
WebBrowser implementează deja metode de navigare (Home, Go, etc.), aceste metode trebuie doar apelate.
La apăsarea ENTER în TextBox să se realizeze navigarea la URL-ul introdus.
Să se blocheze accesul la pagini Web ale căror URL-uri conțin anumite cuvinte cheie (trecute într-un vector sau listă în codul sursă).

“Blocarea” se poate realiza interceptând evenimentul Navigating și verificând conținutul e.Url.ToString().
e.Cancel = true – pentru blocarea navigării.
4.1 Să se modifice codul anterior așa încât căutarea în lista de cuvinte cheie să se realizeze folosind LINQ.

4.2 Căutarea să se realizeze prin LINQ + AsyncTask.
Să se utilizeze clasa Trace pentru a scrie într-un fișier text timpul sistemului (data, ora, minut, secunda, milisecunda) și un mesaj la care a avut loc un eveniment selectat de utilizator.

Scrierea se va realiza prin AsyncTask, fără ca firul apelant să aștepte finalizarea scrierii.
Să se adauge un TextBox care va permite adăugarea de cuvinte cheie după care se realizează blocarea accesului la anumite pagini.

Folosind LINQ se va verifica dacă un cuvânt cheie introdus există deja în listă.

Lista de cuvinte cheie adăugată va fi vizibilă într-un ComboBox adăugat la ToolStrip.












