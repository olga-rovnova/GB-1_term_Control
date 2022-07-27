# GB-1_term_Control
**Задача** 

Написать программу, которая из имеющегося массива строк 
формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры 
либо задать на старте выполнения алгоритма. 

**Уточнение задания**
1. Первоначальный массив задаем на старте выполнения алгоритма:
пусть это будут следующие символы: "hello", "2", "world", ":-)" 
2. Для проверки выполнения программы будем выводить первоначальный массив и искомый.
3. Т.к. в задаче не оговорен способ вывода информации, условимся использовать консоль.

**Основные этапы решения**
1. Подзадача - нахождение длины искомого массива строк *string[] text* путем подсчета строк, состоящих не более, чем из трех элементов - используется числовая переменная *int count*.
2. Основная задача - запись найденных элементов в новый массив строк - *string[] new text*;
используется вспомогательная числовая переменная *int iCurrent* для текущей позиции строки 
из не более, чем 3 символов.
3. Метод вывода масивов (оформление: в квадратных скобках, через запятую) *void PrintArr*