﻿using Sync.Source;
using Sync.Source.BiliBili.BiliBili_dm;
using System;

namespace DefaultPlugin.Source
{
    class BiliBiliDanmuku : BaseDanmakuEvent
    {
        public BiliBiliDanmuku(DanmakuModel instance)
        {
            this.Danmuku = instance.CommentText;
            this.SenderName = instance.CommentUser;
            this.SendTime = DateTime.Now.ToShortTimeString();
        }

    }

    class BiliBiliGift : BaseGiftEvent
    {
        public BiliBiliGift(DanmakuModel instance)
        {
            this.GiftCount = int.Parse(instance.GiftNum);
            this.GiftName = instance.GiftName;
            this.SenderName = instance.GiftUser;
            this.SendTime = DateTime.Now.ToShortTimeString();

        }
    }
}
