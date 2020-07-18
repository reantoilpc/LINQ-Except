using System;
using System.Diagnostics.CodeAnalysis;

namespace src.Model
{
    public class Member : IEquatable<Member>
    {
        /// <summary>
        /// 流水號
        /// </summary>
        /// <value></value>
        public int Id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        /// <value></value>
        public string Name { get; set; }

        public bool Equals([AllowNull] Member other)
        {
            if (other is null)
            {
                return false;
            }

            return this.Id.Equals(other.Id) && this.Name.Equals(other.Name);
        }

        public override bool Equals(object obj) => this.Equals(obj as Member);
        public override int GetHashCode() => (Id, Name).GetHashCode();
    }
}