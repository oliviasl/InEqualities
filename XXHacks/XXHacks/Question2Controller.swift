//
//  Question2Controller.swift
//  XXHacks
//
//  Created by Stephen Lai on 3/23/19.
//  Copyright © 2019 Olivia Lai. All rights reserved.
//

import Foundation
import UIKit

class Question2Controller: UIViewController {
 
    @IBOutlet weak var question2Answer: UILabel!
    
    @IBOutlet weak var question2Correct: UILabel!
    
    @IBOutlet weak var question2Incorrect: UILabel!
    
    @IBOutlet weak var question2Next: UIButton!
    
    @IBOutlet weak var question2True: UIButton!
    
    @IBOutlet weak var question2False: UIButton!
    
    override func viewDidLoad() {
        super.viewDidLoad()

        question2Answer.isHidden = true
        question2Correct.isHidden = true
        question2Incorrect.isHidden = true
        question2Next.isHidden = true
        question2True.isHidden = false
        question2False.isHidden = false
        
    }

    @IBAction func question2TruePressed(_ sender: Any) {
        
        question2Answer.isHidden = false
        question2Incorrect.isHidden = false
        question2Next.isHidden = false
        question2True.isHidden = true
        question2False.isHidden = true
        
    }
    
    
    @IBAction func question2FalsePressed(_ sender: Any) {
        
        question2Answer.isHidden = false
        question2Correct.isHidden = false
        question2Next.isHidden = false
        question2True.isHidden = true
        question2False.isHidden = true
        
    }
    
}

