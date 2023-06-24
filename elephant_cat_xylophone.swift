import UIKit

class MindOasisController: UIViewController {
    
    // MARK: View Outlets
    @IBOutlet weak var imageView: UIImageView!
    @IBOutlet weak var activityIndicator: UIActivityIndicatorView!
    @IBOutlet weak var button: UIButton!
    
    // MARK: Properties
    private let imageURL = URL(string: "https://mindoasis.org/images/photo.jpg")!
    private var imageDataTask: URLSessionDataTask?
    
    // MARK: Life Cycle
    override func viewDidLoad() {
        super.viewDidLoad()
        setupView()
    }
    
    override func viewWillAppear(_ animated: Bool) {
        super.viewWillAppear(animated)
        fetchImage()
    }
    
    override func viewWillDisappear(_ animated: Bool) {
        super.viewWillDisappear(animated)
        imageDataTask?.cancel()
    }
    
    // MARK: Setup Method
    private func setupView() {
        activityIndicator.hidesWhenStopped = true
        activityIndicator.startAnimating()
        
        button.setTitle("Retry", for: .normal)
        button.setTitleColor(.systemBlue, for: .normal)
        button.layer.cornerRadius = 10
    }
    
    // MARK: Image Fetch Method
    private func fetchImage() {
        guard let dataTask = imageDataTask else {
            return
        }
        
        dataTask.resume()
    }
    
    // MARK: Retry Button Method
    @IBAction func didTapRetryButton(_ sender: UIButton) {
        activityIndicator.startAnimating()
        fetchImage()
    }
    
    // MARK: Data Task Method
    private func getImageDataTask() -> URLSessionDataTask {
        let task = URLSession.shared.dataTask(with: imageURL) { data, response, error in
            guard let data = data,
                let image = UIImage(data: data) else {
                    DispatchQueue.main.async {
                        self.activityIndicator.stopAnimating()
                        self.button.isEnabled = true
                        self.button.alpha = 1.0
                    }
                    return
            }
            
            DispatchQueue.main.async {
                self.imageView.image = image
                self.activityIndicator.stopAnimating()
                self.button.isEnabled = false
                self.button.alpha = 0.0
            }
        }
        
        imageDataTask = task
        return task
    }
}