// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OnceMi.IdentityServer4.Models
{
    public class LoginInputModel
    {
        [Required(ErrorMessage = "�û�������Ϊ��")]
        [Description("�û���")]
        public string Username { get; set; }

        [Required(ErrorMessage = "���벻��Ϊ��")]
        [Description("����")]
        public string Password { get; set; }

        [Required(ErrorMessage = "��֤�벻��Ϊ��")]
        [Description("��֤��")]
        public string Code { get; set; }

        public bool RememberLogin { get; set; }

        public string ReturnUrl { get; set; }
    }
}