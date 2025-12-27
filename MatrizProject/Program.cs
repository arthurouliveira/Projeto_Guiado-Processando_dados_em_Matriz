// Inicializa o número de tarefas/atividades
int examAssignments = 5;

// Notas dos alunos em cada tarefa
int[] sophiaScores = [93, 87, 98, 95, 100, 99, 94];
int[] nicolasScores = [80, 83, 82, 88, 85, 98, 99, 79];
int[] zahiraScores = [84, 96, 73, 85, 79, 75, 86];
int[] jeongScores = [90, 92, 98, 100, 97, 81];

// Lista com os nomes dos alunos
string[] studentName = ["Sophia", "Nicolas", "Zahira", "Jeong"];

// Array para armazenar as notas do aluno atual
int[] studentScores = new int[10];

// Variável para armazenar o conceito/letra da nota
string currentStudentLetterGrade = "";

// Cabeçalho da tabela de saída
Console.Clear();
Console.WriteLine("Student\t\tGrade\tLetter Grade\n");

// Loop para cada aluno
foreach (string name in studentName)
{
    string currentStudent = name; // Nome do aluno atual

    // Seleciona o array de notas correspondente ao aluno
    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Nicolas")
        studentScores = nicolasScores;

    else if (currentStudent == "Zahira")
        studentScores = zahiraScores;

    else if (currentStudent == "Jeong")
        studentScores = jeongScores;

    int sumAssignmentScores = 0; // Soma das notas

    decimal currentStudentGrade = 0; // Média do aluno

    int gradedAssignments = 0; //

    // Soma todas as notas do aluno
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
        sumAssignmentScores += score;

        else
            sumAssignmentScores += score / 10;
    }

    // Calcula a média do aluno
    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;
    
    // Define o conceito/letra da nota baseado na média
    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    // Exibe o resultado do aluno
     Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");

}

// Mensagem final para o usuário
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();