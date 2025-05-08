using Content.Shared.SD.RadialSelector;
using Content.Shared.SD.ShortConstruction;
using Content.Shared.UserInterface;
using Robust.Server.GameObjects;

namespace Content.Server.SD.ShortConstruction
{
    public sealed class ShortConstructionSystem : EntitySystem
    {
        [Dependency] private readonly UserInterfaceSystem _ui = default!;

        public override void Initialize()
        {
            base.Initialize();
            SubscribeLocalEvent<ShortConstructionComponent, BeforeActivatableUIOpenEvent>(BeforeUiOpen);
        }

        private void BeforeUiOpen(Entity<ShortConstructionComponent> ent, ref BeforeActivatableUIOpenEvent args)
        {
            var state = new RadialSelectorState(ent.Comp.Entries);
            _ui.SetUiState(ent.Owner, RadialSelectorUiKey.Key, state);
        }
    }
}
