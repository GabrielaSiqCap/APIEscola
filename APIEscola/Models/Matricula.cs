using System.ComponentModel.DataAnnotations;

namespace APIEscola.Models
{
    public class Matricula
    {

        public Guid MatriculaId { get; set; }

        [Required(ErrorMessage = "O Campo Data de Matricula é Obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "A Data Informada não é Válida")]
        public DateTime DataMatricula { get; set; }

        [Required(ErrorMessage = "O Campo AlunoId é Obrigatório")]
        public Guid AlunoId { get; set; }
        public Aluno? Aluno { get; set; }

        [Required(ErrorMessage = "O Campo TurmaId é Obrigatório")]
        public Guid TurmaId { get; set; }
        public Turma? Turma { get; set; }
    }
}
