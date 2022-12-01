int.TryParse(Console.ReadLine(), out int n);

Dictionary<string, int> polyhedron = new() {
    ["Tetrahedron"] = 4,
    ["Cube"] = 6,
    ["Octahedron"] = 8,
    ["Dodecahedron"] = 12,
    ["Icosahedron"] = 20
};

int totalFaces = 0;
for(int i = 0; i < n; i++)
    totalFaces += polyhedron[Console.ReadLine()];

Console.WriteLine(totalFaces);