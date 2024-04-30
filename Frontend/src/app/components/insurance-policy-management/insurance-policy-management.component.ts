import { Component, OnInit } from '@angular/core';
import { InsurancePolicyService } from '../../services/insurance-policy.service';
import { InsurancePolicy } from '../../models/insurance-policy-management.model';

@Component({
  selector: 'app-insurance-policy',
  templateUrl: './insurance-policy-management.component.html',
  styleUrls: ['./insurance-policy-management.component.css']
})
export class InsurancePolicyComponent implements OnInit {
  policies: InsurancePolicy[] = [];

  constructor(private insurancePolicyService: InsurancePolicyService) { }

  ngOnInit(): void {
    // write your logic here
  }

  loadPolicies(): void {
    // write your logic here
  }

  addPolicy(policy: InsurancePolicy): void {
    // write your logic here
  }
}
