﻿using Microsoft.AspNetCore.Mvc;
            //return RedirectToAction("Index", "Student", null);
            return Json(new { Message = "How are you ? ", Name = " Saif " });
    }
}