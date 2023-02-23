namespace Linkmarker.Core.Utils {
    public readonly struct Optional<T> {
        public T Value { get; }

        public bool IsPresent { get; }

        public Optional(T value) {
            this.Value = value;
            this.IsPresent = value != null;
        }
    }
}