# Итоговая работа
## Задача
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
_Примеры_:
+ ["hello", "2", "world", ":-)"] -> ["2", ":-)"];
+ ["1234", "1567", "-2", "computer science"] -> ["-2"];
+ ["Russia", "Denmark", "Kazan"] -> [];

### Описание решения
1. Для начала пользователя просят ввести элементы через пробел, тем самым получая на ввод массив 

**Шаг 1.** 

Пользователя просят ввести элементы через пробел, тем самым получая на ввод массив строк, используя разбивку на параметры с помощью метода:

    Split

**Шаг 2.** 

Прописыаем основной метод  получения нового массива _(GetArray)_, где длина каждого элемента будет больше или равна 3:

1.   На вход метод принимает одномерный массив строк.

2. Вводим новую переменную _stringSize_ - длина нового массива, которая изначально равна 0. 

3. Чтобы определить длину нового массива, с помощью цикла _for_ пробегаемся по каждому элементу массива и внутри цикла проверяем условие:

        ar[i].Length <= 3

    Если уловие соблюдается, значит _stringSize_ увеличивается на 1, т.е. размер требуемого массива начнет расти.

4. Из полученного на входе массива создаем новый массив строк "_resultArray_" размером _stringSize_, в котором длина каждого элемента будет больше или равна 3. Вводим переменную индекса - _index_. 

5. Снова используем цикл _for_, в котором также проверяем соблюдение условия: 

        ar[i].Length <= 3

    Если условие соблюдается, то элементу массива _resultArray_ с индексом _index_ присваиваетя значение элемента входного массива с текущим индексом и переменная _index_ увеличивается на 1.

    Если условие не выполняется, то переходим к проверке следующего элемента входного массива.


6. На выходе метод возвращает новый полученный одномерный массив _resultArray_.

    **Шаг 3.** Определяем переменную типа string для нового массива - _newArray_, и вызываем метод _GetArray_.

    **Шаг 4.** Проверяем условие для вывода нового массива в консоль:
    * если размер нового массива - 0, т.е. в введенном пользователем массиве нет не одного элемента длиной меньше или равной 3, то на вывод получаем "[]".
    * если размер нового массива 1 и больше, то вызываем метод _PrintArray_ для вывода одномерного массива в консоль.
    
