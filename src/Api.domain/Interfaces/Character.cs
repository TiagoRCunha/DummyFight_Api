using System;

namespace src.Api.domain.Interfaces
{
  public interface ICharacter : IEntity
  {
    String firstname { get; set; }
    String lastname { get; set; }
    String grade { get; set; }
    Int64 experience { get; set; }
    IStatus status { get; set; }
    ISkill skills { get; set; }
    IEquipaments equipaments { get; set; }
    Potions potions { get; set; }
    Single defence { get; set; }
    Single attack { get; set; }
    Single power { get; set; }
    Single stamina { get; set; }

  }
}