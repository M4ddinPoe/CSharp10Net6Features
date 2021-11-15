// See https://aka.ms/new-console-template for more information
using CSharp10Features.AssignmentAndDeclarationInSameDeconstruction;

var point = new Point(5, 8, 2);

//int x = 0;
int y = 0;
int z = 0;

// x wird in der Decontructions initialisiert
(int x, y, z) = point;

