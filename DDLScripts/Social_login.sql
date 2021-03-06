USE [BetterCms]
GO
/****** Object:  Table [bcms_users].[UserSocial]    Script Date: 6/15/2017 11:21:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [IF NOT EXISTS] [bcms_users].[UserSocial](
	[UserId] [uniqueidentifier] NOT NULL,
	[SocialId] [varchar](50) NOT NULL,
	[Type] [nvarchar](20) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [bcms_users].[UserSocial] ([UserId], [SocialId], [Type]) VALUES (N'23874d78-1092-4166-992f-a70500acfa88', N'101103336041610927073', N'google')
INSERT [bcms_users].[UserSocial] ([UserId], [SocialId], [Type]) VALUES (N'a444f311-9250-48fc-a12e-a70500adadf9', N'113479096448289689931', N'google')
INSERT [bcms_users].[UserSocial] ([UserId], [SocialId], [Type]) VALUES (N'f84646ea-aa54-4910-b355-a70500aca302', N'109725149533068_1', N'facebook')
INSERT [bcms_users].[UserSocial] ([UserId], [SocialId], [Type]) VALUES (N'cb6d9ee0-ed43-4854-b460-c726138af267', N'106546994949339537514', N'google')
INSERT [bcms_users].[UserSocial] ([UserId], [SocialId], [Type]) VALUES (N'3b617b77-cf01-485f-9e06-da4812441d72', N'214738765698372', N'facebook')
INSERT [bcms_users].[UserSocial] ([UserId], [SocialId], [Type]) VALUES (N'3b617b77-cf01-485f-9e06-da4812441d72', N'109725149533068', N'facebook')
ALTER TABLE [bcms_users].[UserSocial]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [bcms_users].[Users] ([Id])
GO
