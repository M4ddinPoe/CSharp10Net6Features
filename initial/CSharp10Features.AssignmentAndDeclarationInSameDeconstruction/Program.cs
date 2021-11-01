// See https://aka.ms/new-console-template for more information
using CSharp10Features.AssignmentAndDeclarationInSameDeconstruction;

var point = new Point(5, 8, 2);

// C# 9
int x = 0;
int y = 0;
int z = 0;

(x, y, z) = point;

