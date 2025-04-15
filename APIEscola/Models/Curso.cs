﻿using System.ComponentModel.DataAnnotations;

namespace APIEscola.Models
{
    public class Curso
    {
        public Guid CursoId { get; set; }

        [Required(ErrorMessage = "O Campo Sigla é Obrigatório")]
        [MaxLength(10, ErrorMessage = "A Sigla deve ter no máximo 10 caracteres")]
        public string? Sigla { get; set; }

        [Required(ErrorMessage = "O Campo Descrição é Obrigatório")]
        [MaxLength(255, ErrorMessage = "O Campo Descrição deve ter no máximo 255 caracteres")]
        public string? Descricao { get; set; }
    }
}
