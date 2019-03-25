//
//  Question3Controller.swift
//  XXHacks
//
//  Created by Stephen Lai on 3/23/19.
//  Copyright © 2019 Olivia Lai. All rights reserved.
//

import Foundation
import UIKit

class Question3Controller: UIViewController {
    
    @IBOutlet weak var question3Answer: UILabel!
    
    @IBOutlet weak var question3Correct: UILabel!
    
    @IBOutlet weak var question3Incorrect: UILabel!
    
    @IBOutlet weak var question3Next: UIButton!
    
    @IBOutlet weak var question3True: UIButton!
    
    @IBOutlet weak var question3False: UIButton!
    
    override func viewDidLoad() {
        super.viewDidLoad()

        question3Answer.isHidden = true
        question3Correct.isHidden = true
        question3Incorrect.isHidden = true
        question3Next.isHidden = true
        question3True.isHidden = false
        question3False.isHidden = false
        
        
    }
    
    @IBAction func question3TruePressed(_ sender: Any) {
        
        question3Answer.isHidden = false
        question3Incorrect.isHidden = false
        question3Next.isHidden = false
        question3True.isHidden = true
        question3False.isHidden = true
        
    }
    
    @IBAction func question3FalsePressed(_ sender: Any) {
        
        question3Answer.isHidden = false
        question3Correct.isHidden = false
        question3Next.isHidden = false
        question3True.isHidden = true
        question3False.isHidden = true
        
    }

    
    
}
