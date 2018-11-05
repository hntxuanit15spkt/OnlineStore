﻿using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Models;
using DAL.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineStore.Models.ViewModels;

namespace OnlineStore.Pages.Product
{
    public class DetailModel : PageModel
    {
        private readonly IItemRepository _itemRepository;
        private readonly ICommentRepository _commentRepository;
        private readonly ICustomerRepository _customerRepository;
        public Item Item { get; set; }
        public List<CustomerCommentViewModel> Customers { get; set; }
        public double Average { get; set; }

        public DetailModel(IItemRepository itemRepository, ICommentRepository commentRepository, ICustomerRepository customerRepository)
        {
            _itemRepository = itemRepository;
            _commentRepository = commentRepository;
            _customerRepository = customerRepository;
        }

        public IActionResult OnGet(int? id)
        {
            // int TongDiem = 0;
            int sumEvaluation = 0;

            //Kiểm tra tham số truyền vào có rỗng hay không
            if (id == null)
            {
                return BadRequest();
            }

            //Nếu không thì truy xuất csdl lấy ra sản phẩm tương ứng
            //SANPHAM sp = db.SANPHAMs.SingleOrDefault(n => n.MaSP == id && n.DaXoa == false);

            Item = _itemRepository.Find(n => n.Id == id && n.Deleted == false);

            if (Item == null)
            {
                //Thông báo nếu như không có sản phẩm đó
                return NotFound();
            }

            List<Comment> comments = _commentRepository.GetSome(n => n.CustomerId == id).ToList();

            if (!comments.Any())
            {
                foreach (Comment comment in comments.ToList())
                {
                    sumEvaluation += comment.Evaluation;

                    Customer cus = _customerRepository.Find(comment.CustomerId);

                    Customers.Add(new CustomerCommentViewModel()
                    {
                        CommentId = comment.Id,
                        Content = comment.Content,
                        CustomerId = comment.CustomerId,
                        CustomerName = cus.FirstName + ' ' + cus.LastName,
                        Evaluation = comment.Evaluation,
                        ItemId = comment.ItemId,
                        Time = DateTime.Now
                    });
                }
                Average = sumEvaluation / comments.Count;
            }
            else
            {
                Customers = null;
                Average = 0;
            }
            return Page();
        }
    }
}