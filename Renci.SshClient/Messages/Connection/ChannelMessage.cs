﻿
namespace Renci.SshClient.Messages.Connection
{
    internal abstract class ChannelMessage : Message
    {
        public uint LocalChannelNumber { get; set; }

        protected override void LoadData()
        {
            this.LocalChannelNumber = this.ReadUInt32();
        }

        protected override void SaveData()
        {
            this.Write(this.LocalChannelNumber);
        }

        public override string ToString()
        {
            return string.Format("{0} : #{1}", this.MessageType, this.LocalChannelNumber);
        }
    }
}
