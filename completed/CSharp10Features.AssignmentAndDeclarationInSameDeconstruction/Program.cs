// See https://aka.ms/new-console-template for more information
using CSharp10Features.AssignmentAndDeclarationInSameDeconstruction;

var point = new Point(5, 8, 2);

// C# 9
int x = 0;
int y = 0;
int z = 0;

(x, y, z) = point;

// C#10
(int x2, int y2, int z2) = point;

