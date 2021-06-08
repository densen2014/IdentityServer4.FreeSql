// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


namespace OnceMi.IdentityServer4.Models
{
    public class ConsentOptions
    {
        public static bool EnableOfflineAccess = true;
        public static string OfflineAccessDisplayName = "�ѻ�����";
        public static string OfflineAccessDescription = "����Ӧ�ó������Դ����ʹ�������ѻ�״̬��";

        public static readonly string MustChooseOneErrorMessage = "������Ҫѡ��һ��";
        public static readonly string InvalidSelectionErrorMessage = "��Ч��ѡ��";
    }
}
