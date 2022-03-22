﻿using System;

namespace SolastaCommunityExpansion.Builders
{
    public delegate bool IsFeatMacthingPrerequisites(
          FeatDefinition feat,
          RulesetCharacterHero hero,
          ref string prerequisiteOutput);

    public class FeatDefinitionCustom : FeatDefinition
    {
        public IsFeatMacthingPrerequisites IsFeatMacthingPrerequisites;
    }

    public class FeatDefinitionCustomBuilder : FeatDefinitionBuilder<FeatDefinitionCustom, FeatDefinitionCustomBuilder>
    {
        #region Constructors
        protected FeatDefinitionCustomBuilder(FeatDefinitionCustom original) : base(original)
        {
        }

        protected FeatDefinitionCustomBuilder(string name, Guid namespaceGuid) : base(name, namespaceGuid)
        {
        }

        protected FeatDefinitionCustomBuilder(string name, string definitionGuid) : base(name, definitionGuid)
        {
        }

        protected FeatDefinitionCustomBuilder(string name, bool createGuiPresentation = true) : base(name, createGuiPresentation)
        {
        }

        protected FeatDefinitionCustomBuilder(FeatDefinitionCustom original, string name, bool createGuiPresentation = true) : base(original, name, createGuiPresentation)
        {
        }

        protected FeatDefinitionCustomBuilder(FeatDefinitionCustom original, string name, Guid namespaceGuid) : base(original, name, namespaceGuid)
        {
        }

        protected FeatDefinitionCustomBuilder(FeatDefinitionCustom original, string name, string definitionGuid) : base(original, name, definitionGuid)
        {
        }
        #endregion

        public FeatDefinitionCustomBuilder SetValidations(params IsFeatMacthingPrerequisites[] validations)
        {
            foreach(var isFeatMacthingPrerequisites in validations)
            {
                Definition.IsFeatMacthingPrerequisites += isFeatMacthingPrerequisites;
            }

            return this;
        }
    }
}
