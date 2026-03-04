Package Dispatch Service
-----------------------------------------
This project implements a package classification system used to determine how packages should be dispatched in an automated warehouse environment.
Packages are classified into three categories based on their dimensions and mass.

----------------------------------------------
Dispatch Rules

A package can be bulky, heavy, or both.

Bulky: 

A package is considered bulky if:
Volume ≥ 1,000,000 cm³
(width × height × length)
OR any dimension ≥ 150 cm

Heavy: 

A package is considered heavy if:
Mass ≥ 20 kg

--------------------------

Classification
---------------------
| Condition               | Result   |
| ----------------------- | -------- |
| Not bulky and not heavy | STANDARD |
| Bulky or heavy          | SPECIAL  |
| Bulky and heavy         | REJECTED |


Technologies Used
----------------------------

C#
.NET
NUnit (Unit Testing)