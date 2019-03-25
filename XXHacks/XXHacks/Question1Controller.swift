//
//  Question1Controller.swift
//  XXHacks
//
//  Created by Stephen Lai on 3/23/19.
//  Copyright © 2019 Olivia Lai. All rights reserved.
//

import Foundation
import UIKit

class Question1Controller: UIViewController {
    
    @IBOutlet weak var question1Answer: UILabel!
    
    @IBOutlet weak var question1Correct: UILabel!
    
    @IBOutlet weak var question1Incorrect: UILabel!
    
    @IBOutlet weak var question1Next: UIButton!
    
    @IBOutlet weak var question1True: UIButton!
    
    @IBOutlet weak var question1False: UIButton!
    
    
    override func viewDidLoad() {
        super.viewDidLoad()
        
        question1Answer.isHidden = true
        question1Correct.isHidden = true
        question1Incorrect.isHidden = true
        question1Next.isHidden = true
        question1True.isHidden = false
        question1False.isHidden = false
        
    }
    
    @IBAction func question1TruePressed(_ sender: Any) {
        
        question1Answer.isHidden = false
        question1Correct.isHidden = false
        question1Next.isHidden = false
        question1True.isHidden = true
        question1False.isHidden = true
        
    }
    
    @IBAction func question1FalsePressed(_ sender: Any) {
        
        question1Answer.isHidden = false
        question1Incorrect.isHidden = false
        question1Next.isHidden = false
        question1True.isHidden = true
        question1False.isHidden = true
        
    }
    
    
}
