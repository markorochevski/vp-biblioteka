## Проектна задача по предметот Визуелно програмирање

## Windows forms library

#### Windows forms project by: Gala Miljkovikj, Marko Rochevski.

### Целта на оваа апликација е да го олесни процесот на пребарување и изнајмување книги од библиотека. 

1.	Начин на користење
На главниот прозорец е прикажана листа на книги кои се наоѓаат во базата на податоци на библиотеката. 

Корисникот може  да пребарува според одреден параметар (наслов, автор или категорија)  кој ќе го внесе во полето над листата, по што треба да го притисне копчето ПРЕБАРАЈ. Откако ќе го притисне копчето во листата се прикажуваат филтрирани резултати од пребарувањето.
Доколку корисникот сака повторно да ја види целосната листа на книги го селектира radio button за ЦЕЛОСНА ЛИСТА, а доколку повторно сака да ги види резултатите од пребарувањето избира radio button ПРЕБАРУВАЊЕ.
На формата постои и опција за додавање на книги во базата на библиотеката. Тоа е овозможено со клик на копчето ДОДАДИ КНИГА, при што се отвара нова форма за додавање на книги.

Корисникот треба да ги пополни полињата соодветно, при што доколку некое од нив е празно се појавува порака за грешка. Откако сите полиња ќе бидат пополнети и ќе се притисне на копчето додади формата се затвара и соодветната книга се додава во базата.

Доколку корисникот сака да види повеќе детали во врска со некоја книга мора да ја селектира книгата од листата, при што копчето прикажи детали ќе може да се користи.

Доколку се кликне копчето ПРИКАЖИ ДЕТАЛИ се прикажува форма со податоци за наслов, автор, категорија и куса содржина за селектираната книга.

Со селекција на книга од листата се отклучува и копчето ДОДАДИ ВО КОШНИЧКА,
кое му овозможува на корисникот  да ја додаде книгата која сака да ја изнајми во кошничката.

Доколку е селектирана книга од кошничката, се отклучува копчето ОТСТРАНИ ОД КОШНИЧКА. Со ова копче селектираната книга се отстранива од листата на книги во кошничка.

Со клик на копчето НАРАЧАЈ се отвара 'MessageBox' каде што корисникот одлучува дали ќе ги изнајми книгите во кошничката. Доколку кликне YES, се отвара форма за контакт информации на корисникот. Ниедно од полињата не смее да биде празно, 
Email мора да биде во дадениот формат и бројот за контакт мора да содржи 9 бројки.

Кога правилно ќе се пополни фомрата се кликнува на кочето НАРАЧАЈ, по што корисникот добива порака

2.	Решение на проблемот
•	Податоците за книгите се чуваат во локална база Books.mdf. Во оваа база има табела со име 'Books'. Секоја книга од табелата има свое id (self  increment), наслов, автор, категорија и куса содржина. 
•	Листата со книги се исполнува во настанот 'Form1_Load' преку функцијата 'Ispolni()'.
•	Пребарувањето се извршува во 'btnPrebaraj_Click' со извршување на стрингот:  
```c#
String query = "SELECT Title FROM [Books] WHERE Title LIKE '%" + tbPrebaraj.Text + "%' OR Category LIKE '%" + tbPrebaraj.Text + "%' OR Author LIKE '%" + tbPrebaraj.Text + "%' ORDER BY Title";
```
каде што 'tbPrebaraj.Text' е вредноста на полето за пребарување.
•	Податоците од формата за додавање на книги во библиотеката се додаваат со помош на 'INSERT' наредба за додавање на книги во табелата 'Books'.
```c#
String query = "INSERT INTO [Books] (Title, Author, Category, Content) VALUES(@Title, @Author, @Category, @Content)";
            SqlCommand cmd = new SqlCommand(query, konekcija);
            cmd.Parameters.AddWithValue("@Title", tbNaslov.Text);
            cmd.Parameters.AddWithValue("@Author", tbAvtor.Text);
            cmd.Parameters.AddWithValue("@Category", tbKategorija.Text);
            cmd.Parameters.AddWithValue("@Content", tbContent.Text);
```
•	За повторно да се прикажат сите книги во листата при клик на radio button ЦЕЛОСНА ЛИСТА повторно се повикува функцијата 'Ispolni()', a при клик на radio button ПРЕБАРУВАЊЕ се повикува 'btnPrebaraj_Click'.
•	На формата за додавање на книга, како и кај формата за контакт информации на корисникот има настан 'Validating' на сите текст полиња, каде што доколку полето е празно се појавува 'errorProvider' порака за грешка. Дополнитекно кај формата за контакт информации има и валидација за проверка дали емаил адресата е во точен формат.
